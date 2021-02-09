using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Samples.Pages
{
    public class IndexModel : PageModel
    {         
        public int PageSize=10;

        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; }

        public List<int> PagedData { get; set; }  

        public int TotalItems => 286;

        public void OnGet()
        {
            PagedData = new List<int>();
            var startIndex = (PageIndex - 1) * PageSize;
            var endIndex = startIndex + PageSize;
            for (int i = startIndex; i < endIndex; i++)
            {
                PagedData.Add(i);
            }
        }
    }
}
