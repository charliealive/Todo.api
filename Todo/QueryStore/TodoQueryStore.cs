using Microsoft.AspNetCore.Mvc;
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

        public async Task<IEnumerable<TodoModel>> PostTodosAsync(TodoModel todo)
        {
            todoContext.Todos.Add(todo);
            await todoContext.SaveChangesAsync();

            return CreatedAtAction("GetTodoid", new { id = todo.Id }, todo);
            
        }
    }
}
