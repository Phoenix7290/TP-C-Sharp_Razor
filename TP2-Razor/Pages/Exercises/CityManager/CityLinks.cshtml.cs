using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class CityLinksModel : PageModel
    {
        public List<string> Cities { get; set; }

        public void OnGet()
        {
            Cities = new List<string> { "Rio", "São Paulo", "Brasília" };
        }
    }
}
