using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;

namespace Webdiyer
{
    public class RazorPagerMetaData
    {
        public int TotalItemCount { get; set; }

        public int CurrentPageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalPageCount => (int)Math.Ceiling(TotalItemCount / (double)PageSize);

        public List<PagerItem> PagerItems;

        private RouteValueDictionary _routeValues { get; }

        private IUrlHelper _urlHelper { get; }

        public string PageIndexParameterName { get; }

        public bool HasPreviousPage => CurrentPageIndex > 1;

        public bool HasNextPage => CurrentPageIndex < TotalPageCount;

        public bool IsFirstPage => CurrentPageIndex == 1;

        public bool IsLastPage => CurrentPageIndex == TotalPageCount;

        public string FirstPageUrl => generatePaginationUrl(1);

        public string UrlTemplate => generatePaginationUrl(int.MinValue).Replace(int.MinValue.ToString(), "__" + PageIndexParameterName + "__");

        public string NextPageUrl
        {
            get
            {
                var nextPageIndex = CurrentPageIndex + 1;
                if (nextPageIndex > TotalPageCount)
                {
                    nextPageIndex = TotalPageCount;
                }
                return generatePaginationUrl(nextPageIndex);
            }
        }

        public string PreviousPageUrl
        {
            get
            {
                var prevPageIndex = CurrentPageIndex - 1;
                if (prevPageIndex < 1)
                {
                    prevPageIndex = 1;
                }
                var url = generatePaginationUrl(prevPageIndex);
                return url;
            }
        }

        public string LastPageUrl => generatePaginationUrl(TotalPageCount);

        public string CurrentPageUrl => generatePaginationUrl(CurrentPageIndex);

        string generatePaginationUrl(int pageIndex)
        {
            var rv = new RouteValueDictionary(_routeValues);
            rv[PageIndexParameterName] = pageIndex;
            return _urlHelper.Page(_routeValues["page"] as string, rv);
        }


        public RazorPagerMetaData(int total, int pageIndex, int pageSize, string pageParameterName, RouteValueDictionary routeValues, int maxPagerItems, IUrlHelper urlHelper)
        {
            TotalItemCount = total;
            CurrentPageIndex = pageIndex;
            PageSize = pageSize;
            _urlHelper = urlHelper;
            _routeValues = routeValues;
            PageIndexParameterName = pageParameterName;

            var _startPageIndex = CurrentPageIndex - (maxPagerItems / 2);
            if (_startPageIndex + maxPagerItems > TotalPageCount)
            {
                _startPageIndex = TotalPageCount + 1 - maxPagerItems;
            }
            if (_startPageIndex < 1)
            {
                _startPageIndex = 1;
            }

            // end page index
            var _endPageIndex = _startPageIndex + maxPagerItems - 1;
            if (_endPageIndex > TotalPageCount)
            {
                _endPageIndex = TotalPageCount;
            }
            PagerItems = new List<PagerItem>();
            for (int i = _startPageIndex; i <= _endPageIndex; i++)
            {
                routeValues[pageParameterName] = i;
                PagerItems.Add(new PagerItem(i, urlHelper.Page(routeValues["page"] as string, routeValues), i == CurrentPageIndex));
            }
        }
    }

    public class PagerItem
    {
        public int PageIndex { get; set; }

        public string Url { get; set; }

        public bool IsCurrent { get; set; }

        public PagerItem(int pageIndex, string url, bool isCurrent)
        {
            PageIndex = pageIndex;
            Url = url;
            IsCurrent = isCurrent;
        }
    }
}
