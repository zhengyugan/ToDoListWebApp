using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoListWebApp.Models;
using ToDoListWebApp.Services;

namespace ToDoListWebApp.Pages
{
    public class NewModel : PageModel
    {
        private readonly ToDoService toDoService;
        [BindProperty]
        public ToDo ToDo { get; set; }
        public NewModel(ToDoService toDoService)
        {
            this.toDoService = toDoService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await toDoService.AddAsync(ToDo);
            return LocalRedirect("/list");
        }
    }
}
