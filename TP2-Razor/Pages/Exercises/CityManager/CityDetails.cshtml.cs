using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class CityDetailsModel : PageModel
    {
        public string CityName { get; private set; }

        public void OnGet(string cityName)
        {
            CityName = cityName;
        }
    }
}