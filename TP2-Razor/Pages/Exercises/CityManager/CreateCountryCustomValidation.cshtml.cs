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
            [Required(ErrorMessage = "O nome do país é obrigatório.")]
            public string CountryName { get; set; }

            [Required(ErrorMessage = "O código do país é obrigatório.")]
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
                        "O código do país deve começar com a mesma letra que o nome do país.");
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
