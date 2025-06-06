using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TP3_Razor.Data;
using TP3_Razor.Models;

namespace TP3_Razor.Pages.Properties
{
    public class EditPropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public EditPropertyModel(CityBreaksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Property Property { get; set; }
        public SelectList CitySelectList { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Property = await _context.Properties.FindAsync(id);
            if (Property == null)
            {
                return NotFound();
            }

            CitySelectList = new SelectList(await _context.Cities.ToListAsync(), "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                CitySelectList = new SelectList(await _context.Cities.ToListAsync(), "Id", "Name");
                return Page();
            }

            var propertyToUpdate = await _context.Properties.FindAsync(Property.Id);
            if (propertyToUpdate == null)
            {
                return NotFound();
            }

            await TryUpdateModelAsync(
                propertyToUpdate,
                "Property",
                p => p.Name, p => p.PricePerNight, p => p.CityId);

            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}