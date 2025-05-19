using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2_Razor.Models;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class CreateMultipleCountriesModel : PageModel
    {
        [BindProperty]
        public List<InputModel> Input { get; set; } = new List<InputModel>();

        public List<Country> Countries { get; set; } = new List<Country>();

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
        }

        public void OnGet()
        {
            for (int i = 0; i < 5; i++)
            {
                Input.Add(new InputModel());
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Countries = Input
                    .Where(i => !string.IsNullOrEmpty(i.CountryName) || !string.IsNullOrEmpty(i.CountryCode))
                    .Select(i => new Country
                    {
                        CountryName = i.CountryName,
                        CountryCode = i.CountryCode
                    })
                    .ToList();
            }
            return Page();
        }
    }
}
