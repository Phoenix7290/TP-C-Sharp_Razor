using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TP3_Razor.Data;
using TP3_Razor.Models;

namespace TP3_Razor.Pages.Properties
{
    public class CreatePropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public CreatePropertyModel(CityBreaksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Property Property { get; set; }
        public SelectList CitySelectList { get; set; }

        public async Task OnGetAsync()
        {
            CitySelectList = new SelectList(await _context.Cities.ToListAsync(), "Id", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                CitySelectList = new SelectList(await _context.Cities.ToListAsync(), "Id", "Name");
                return Page();
            }

            await _context.Properties.AddAsync(Property);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}