using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PSCJobs.Pages
{
    public class LoginModel : PageModel
    {
        //public string Message { get; set; }
        public string Username { get; set; }

        [DataType(DataType.Password)]
        string Password { get; set; }

        public void OnGet()
        {
            //Message = "Please login below.";
        }

        public async Task<IActionResult> OnPostLogIn()
        {
            try
            {
                // Verification.  
                if (ModelState.IsValid)
                {
                    // Initialization.  
                    //var loginInfo = await this.databaseManager.LoginByUsernamePasswordMethodAsync(this.LoginModel.Username, this.LoginModel.Password);

                    // Verification.  
                    //if (loginInfo != null && loginInfo.Count() > 0)
                    //{
                    //    // Initialization.  
                    //    var logindetails = loginInfo.First();

                    //    // Login In.  
                    //    await this.SignInUser(logindetails.Username, false);

                    //    // Info.  
                    //    return this.RedirectToPage("/Index");
                    //}
                    //else
                    //{
                    //    // Setting.  
                    //    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    //}
                }
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }

            // Info.  
            return this.Page();
        }
    }
}
