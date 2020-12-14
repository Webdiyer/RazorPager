using System;
using System.Collections.Generic;
using System.Text;

namespace Webdiyer
{
    public class RazorPagerItem
    {
        public int PageIndex { get; set; }

        public string Url { get; set; }

        public bool IsCurrent { get; set; }

        public RazorPagerItem(int pageIndex, string url, bool isCurrent)
        {
            PageIndex = pageIndex;
            Url = url;
            IsCurrent = isCurrent;
        }
    }
}
