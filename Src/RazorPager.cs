using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Webdiyer.Razor
{
    [HtmlTargetElement("razorpager")]
    public class RazorPager:TagHelper
    {
        private IHtmlHelper _htmlHelper;
        private HtmlEncoder _htmlEncoder;
        private IUrlHelperFactory _urlHelperFactory;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public RazorPager(IHtmlHelper htmlHelper,HtmlEncoder htmlEncoder,
            IUrlHelperFactory urlHelperFactory)
        {
            _htmlHelper = htmlHelper;
            _htmlEncoder = htmlEncoder;
            _urlHelperFactory = urlHelperFactory;
        }


        public override async Task ProcessAsync(TagHelperContext context, 
            TagHelperOutput output)
        {
            var vca = _htmlHelper as IViewContextAware;
            if (vca != null)
            {
                vca.Contextualize(ViewContext);
            }
            output.TagName = TagName;
            output.TagMode = TagMode.StartTagAndEndTag;
            var urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            var routeValues = ViewContext == null
                ? new RouteValueDictionary()
                : ViewContext.RouteData.Values;
            int pageIndex;
            string strIndex = routeValues != null && 
                routeValues.ContainsKey(PageIndexParameterName)
                ? (string)routeValues[PageIndexParameterName]
                : (string)ViewContext?.HttpContext?.Request?.Query[PageIndexParameterName];
            if (!int.TryParse(strIndex, out pageIndex))
            {
                pageIndex = 1;
            }
            //如果当前页超出总页数，则重置当前页为最后一页
            while (TotalItemCount > 0 && TotalItemCount <= (pageIndex - 1) * PageSize)
            {
                pageIndex--;
            }
            if (pageIndex < 1)
            {
                pageIndex = 1;
            }

            var metaData = new RazorPagerMetaData(TotalItemCount, 
                pageIndex, PageSize, 
                PageIndexParameterName, 
                routeValues, MaxPagerItems, 
                urlHelper);
            IHtmlContent partialContent;
            if (!TemplateName.Contains('\\') && !TemplateName.Contains('/')) //not a relative path
            {
                partialContent = await _htmlHelper.PartialAsync("RazorPager_"
                    +TemplateName, metaData);
            }
            else
            {
                partialContent = await _htmlHelper.PartialAsync(TemplateName, metaData);
            }
            var writer = new StringWriter();
            writer.WriteLine();
            partialContent.WriteTo(writer, _htmlEncoder);
            output.Content.SetHtmlContent(writer.ToString());
        }

        #region properties
        public string TemplateName { get; set; } = "Basic";

        public int MaxPagerItems { get; set; } = 10;

        public int TotalItemCount { get; set; }

        public int PageSize { get; set; } = 10;

        public string TagName { get; set; } = "div";

        public string PageIndexParameterName { get; } = "pageindex";

        #endregion
    }
}
