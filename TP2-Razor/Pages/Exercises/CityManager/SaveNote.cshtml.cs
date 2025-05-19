using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP2_Razor.Pages.Exercises.CityManager
{
    public class SaveNoteModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public string FilePath { get; set; }
        public string FileName { get; set; }

        public class InputModel
        {
            public string Content { get; set; }
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(Input.Content))
            {
                ModelState.AddModelError("Input.Content", "O conteúdo da nota não pode estar vazio.");
                return Page();
            }

            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            FileName = $"note-{timestamp}.txt";

            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");
            string filePath = Path.Combine(directoryPath, FileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            await System.IO.File.WriteAllTextAsync(filePath, Input.Content);

            FilePath = $"/files/{FileName}";

            return Page();
        }
    }
}
