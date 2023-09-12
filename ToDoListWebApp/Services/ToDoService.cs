using Microsoft.EntityFrameworkCore;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Services
{
    public class ToDoService
    {
        private readonly ToDoContext context;

        public ToDoService(ToDoContext context)
        {
            this.context = context;
        }

        public async Task<List<ToDo>> GetToDosAsync()
        {
            return await context.ToDos.ToListAsync();
        }

        public async Task<int> GetToDoCountAsync()
        {
            return await context.ToDos.CountAsync();
        }

        public async Task<ToDo> GetByIdAsync(int id)
        {
            return await context.ToDos.FindAsync(id);
        }

        public async Task AddAsync(ToDo toDo)
        {
            await context.ToDos.AddAsync(toDo);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ToDo toDo)
        {
            context.ToDos.Update(toDo);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ToDo toDo)
        {
            context.ToDos.Remove(toDo);
            await context.SaveChangesAsync();
        }
    }
}
