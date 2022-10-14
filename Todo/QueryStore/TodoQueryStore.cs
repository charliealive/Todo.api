using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.QueryStore
{
    public class TodoQueryStore:ITodoQueryStore
    {
        private readonly TodoContext todoContext;

        public TodoQueryStore(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        //Calling Context method
        public async Task<IEnumerable<TodoModel>> GetTodosAsync()
        {
            return await todoContext.Todos.ToListAsync();
        }
    }
}
