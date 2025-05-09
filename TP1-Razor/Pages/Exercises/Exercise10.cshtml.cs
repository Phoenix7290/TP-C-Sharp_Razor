using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1_Razor.Pages.Exercises
{
    public class Exercise10Model : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public Product SubmittedProduct { get; set; }

        public void OnGet()
        {
            Product = new Product();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                SubmittedProduct = Product;
            }
            return Page();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
