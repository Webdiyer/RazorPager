using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Webdiyer
{
    [HtmlTargetElement("razorpager")]
    public class RazorPager:TagHelper
    {
        private HtmlHelper _htmlHelper;
        private HtmlEncoder _htmlEncoder;
        private IUrlHelperFactory _urlHelperFactory;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public RazorPager(IHtmlHelper htmlHelper,HtmlEncoder htmlEncoder,IUrlHelperFactory urlHelperFactory)
        {
            _htmlHelper = htmlHelper as HtmlHelper;
            _htmlEncoder = htmlEncoder;
            _urlHelperFactory = urlHelperFactory;
        }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (_htmlHelper as IViewContextAware).Contextualize(ViewContext);
            output.TagName = "razorpager";
            output.TagMode = TagMode.StartTagAndEndTag;
            var urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            var rvalue = ViewContext.RouteData.Values;
            var qryPrms =ViewContext.HttpContext.Request.Query.ToDictionary(d => d.Key, d => d.Value.ToString());
            if (qryPrms != null && qryPrms.Any())
            {
                foreach (var kv in qryPrms)
                {
                    if (!rvalue.ContainsKey(kv.Key))
                    {
                        rvalue.Add(kv.Key, kv.Value);
                    }
                }
            }
            int pageIndex;
            string strIndex = rvalue.ContainsKey(PageIndexParameterName) ? rvalue[PageIndexParameterName].ToString() : ViewContext.HttpContext.Request.Query[PageIndexParameterName].ToString();
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

            var metaData = new RazorPagerMetaData(TotalItemCount, pageIndex, PageSize, PageIndexParameterName, rvalue, MaxPagerItems, urlHelper);
            var partial = await _htmlHelper.PartialAsync(TemplateName,metaData);
            var writer = new StringWriter();
            partial.WriteTo(writer, _htmlEncoder);
            output.Content.SetHtmlContent(writer.ToString());
        }

        #region properties
        public string TemplateName { get; set; } = "Basic";

        public int MaxPagerItems { get; set; } = 10;

        public int TotalItemCount { get; set; }

        public int PageSize { get; set; } = 10;

        public string PageIndexParameterName { get; } = "pageindex";

        #endregion
    }
}
