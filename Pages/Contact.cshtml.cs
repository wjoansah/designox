using DESIGNOX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DESIGNOX.Pages
{
    public class ContactModel : PageModel
    {

        public ContactModel(){
        }

        [BindProperty]
        public ContactSubmission ContactSubmission { get; set; }
        public void OnGet()
        {
            // _toastNotification.Success("Setting up the toast notification worked");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Console.WriteLine(string.Join("|", ModelState.Keys.Where(key => key == "ContactSubmission.Name")));
                // Console.WriteLine(ModelState["ContactSubmission.Name"].Errors.Count);

                if(ModelState["ContactSubmission.Name"].Errors.Count > 0){
                    ViewData["showErrorOnName"] = true;
                }

                if(ModelState["ContactSubmission.Email"].Errors.Count > 0){
                    ViewData["showErrorOnEmail"] = true;
                }

                if(ModelState["ContactSubmission.Message"].Errors.Count > 0){
                    ViewData["showErrorOnMessage"] = true;
                }
                return Page();
            }


            return RedirectToPage("./Index");

        }
    }
}
