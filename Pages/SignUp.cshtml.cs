using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YellowSalonWebsite.Pages
{
    public class SignUpModel : PageModel {
        
        public bool hasData = false;
        public string Username = "";
        public string Email = "";
        public int Password = 0;
        public int CornfirmPassword = 0;

        public void OnGet() {

        }
        public void OnPost() {

        }
    }
}
