using System.Collections.Generic;
using System.Threading.Tasks;
using TP3_Razor.Models;

namespace TP3_Razor.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();
        Task<City> GetByNameAsync(string name);
        Task DeleteAsync(int id);
        Task<List<Property>> GetFilteredAsync(decimal? minPrice, decimal? maxPrice, string cityName, string propertyName);
    }
}