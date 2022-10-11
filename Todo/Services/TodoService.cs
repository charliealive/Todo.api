using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Services
{
    public class TodoService:ITodoService
    {
        private readonly TodoContext todoContext;

        public TodoService(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public async Task<IEnumerable<TodoModel>> GetTodosAsync()
        {
            return await todoContext.Todos.ToListAsync();
        }
    }
}
