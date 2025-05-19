using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class CreateCityHandlerModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                Message = $"Cidade submetida: {cityName}";
            }
            return Page();
        }
    }
}
