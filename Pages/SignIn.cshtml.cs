using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YellowSalonWebsite.Pages
{
    public class SignInModel : PageModel
    {
        public bool hasData = false;
        public string Email = " ";
        public int Password = 0;
        
        public void OnGet()
        {
        }
    }
}
