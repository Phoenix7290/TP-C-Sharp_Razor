using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        Products = new List<Product>
        {
            new Product { Name = "Notebook", Price = 3500.00m },
            new Product { Name = "Smartphone", Price = 2000.00m },
            new Product { Name = "Fones de Ouvido", Price = 150.00m }
        };
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}