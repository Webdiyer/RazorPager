using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Samples.Data;
using Samples.Models;

namespace Samples.Pages
{
    public class CustomTemplateModel : PageModel
    {

        public int PageSize = 10;

        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; }

        public List<Employee> PagedEmployees { get; set; }

        public int TotalItems { get; set; }

        DemoDbContext _db;

        public CustomTemplateModel(DemoDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            var qry = _db.Employees.AsQueryable();
            PagedEmployees = qry.OrderBy(e => e.Id).Skip((PageIndex - 1) * PageSize)
                .Take(PageSize).ToList();
            TotalItems = qry.Count();
        }
    }
}
