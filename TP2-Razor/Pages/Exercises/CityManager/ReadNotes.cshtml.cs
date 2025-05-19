using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class ReadNotesModel : PageModel
    {
        public List<string> Files { get; set; } = new List<string>();
        public string SelectedFileName { get; set; }
        public string SelectedFileContent { get; set; }

        public async Task OnGetAsync(string fileName)
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");

            if (Directory.Exists(directoryPath))
            {
                Files = Directory.GetFiles(directoryPath, "*.txt")
                    .Select(Path.GetFileName)
                    .ToList();
            }

            if (!string.IsNullOrEmpty(fileName))
            {
                string filePath = Path.Combine(directoryPath, fileName);
                if (System.IO.File.Exists(filePath)) 
                {
                    SelectedFileName = fileName;
                    SelectedFileContent = await System.IO.File.ReadAllTextAsync(filePath); 
                }
            }
        }
    }
}
