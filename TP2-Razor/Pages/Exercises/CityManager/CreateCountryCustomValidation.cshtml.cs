using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2_Razor.Models;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class CreateCountryCustomValidationModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public Country Country { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O nome do pa�s � obrigat�rio.")]
            public string CountryName { get; set; }

            [Required(ErrorMessage = "O c�digo do pa�s � obrigat�rio.")]
            public string CountryCode { get; set; }
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(Input.CountryName) && !string.IsNullOrEmpty(Input.CountryCode))
            {
                char nameFirstChar = char.ToUpper(Input.CountryName[0]);
                char codeFirstChar = char.ToUpper(Input.CountryCode[0]);

                if (nameFirstChar != codeFirstChar)
                {
                    ModelState.AddModelError("Input.CountryCode",
                        "O c�digo do pa�s deve come�ar com a mesma letra que o nome do pa�s.");
                }
            }

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
