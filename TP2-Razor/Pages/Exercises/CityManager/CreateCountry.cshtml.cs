using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2_Razor.Models;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public Country Country { get; set; }

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Country = new Country
                {
                    CountryName = Input.CountryName,
                    CountryCode = Input.CountryCode
                };
            }
            return Page();
        }
    }
}
