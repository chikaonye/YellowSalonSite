using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YellowSalonWebsite.Pages
{
    public class nailsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

public class NailTypes
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
}
