using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YellowSalonWebsite.Pages
{
    public class men_hairstylesModel : PageModel
    {
        public void OnGet()
        {
        }
    }

    public class HairstyleController : Controller
    {
        
    }
}

public class Hairstyle
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
}
