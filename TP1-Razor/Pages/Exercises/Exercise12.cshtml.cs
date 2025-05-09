using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1_Razor.Models;

namespace TP1_Razor.Pages.Exercises
{
    public class Exercise12Model : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }

        public Event SubmittedEvent { get; set; }

        private readonly Action<Event> _logEventCreation;

        public Exercise12Model()
        {
            _logEventCreation = (e) =>
            {
                Console.WriteLine($"Evento criado: {e.Title}, Data: {e.Date.ToShortDateString()}, Local: {e.Location}");
            };
        }

        public void OnGet()
        {
            Event = new Event();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                SubmittedEvent = Event;
                _logEventCreation?.Invoke(Event);
            }
            return Page();
        }
    }
}
