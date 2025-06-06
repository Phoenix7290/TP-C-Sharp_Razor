using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using TP3_Razor.Models;
using TP3_Razor.Services;

namespace TP3_Razor.Pages.Cities
{
    public class CityDetailsModel : PageModel
    {
        private readonly ICityService _cityService;

        public CityDetailsModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public City City { get; set; }

        public async Task<IActionResult> OnGetAsync(string name)
        {
            City = await _cityService.GetByNameAsync(name);
            if (City == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}