using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP3_Razor.Models;
using TP3_Razor.Services;

namespace TP3_Razor.Pages.Properties
{
    public class FilterPropertiesModel : PageModel
    {
        private readonly ICityService _cityService;

        public FilterPropertiesModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        [BindProperty(SupportsGet = true)]
        public decimal? MinPrice { get; set; }
        [BindProperty(SupportsGet = true)]
        public decimal? MaxPrice { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CityName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PropertyName { get; set; }
        public List<Property> Properties { get; set; }

        public async Task OnGetAsync()
        {
            Properties = await _cityService.GetFilteredAsync(MinPrice, MaxPrice, CityName, PropertyName);
        }
    }
}