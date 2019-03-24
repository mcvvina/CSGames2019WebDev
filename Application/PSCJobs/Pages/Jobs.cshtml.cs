using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PSCJobs.Pages
{
    public class JobsModel : PageModel
    {
        //public string Message { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
        public void OnGet()
        {
            //Message = "Your application description page.";
        }

        public async Task<IActionResult> OnPostSearch()
        {
            return this.Page();
        }
    }
}
