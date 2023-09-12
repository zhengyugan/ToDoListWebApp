using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoListWebApp.Models;
using ToDoListWebApp.Services;

namespace ToDoListWebApp.Pages
{
    public class ListModel : PageModel
    {
        private readonly ToDoService toDoService;

        public List<ToDo> ToDos { get; set; }

        public ListModel(ToDoService toDoService)
        {
            this.toDoService = toDoService;
        }

        public async Task OnGet()
        {
            ToDos = await toDoService.GetToDosAsync();
        }
    }
}
