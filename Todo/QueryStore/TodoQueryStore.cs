using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.QueryStore
{
    public class TodoQueryStore: ITodoQueryStore
        
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

        public async Task<TodoModel> PostTodoAsync(TodoModel todo)
        {
            todoContext.Todos.Add(todo);
            await todoContext.SaveChangesAsync();

            return todo;
        }
        /*public async Task<ActionResult<TodoModel>> PutTodo(int id, TodoModel todo)
        {
            if ( id != todo.Id)
            {
                return BadRequest();
            }

            _context.Entry(todo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return todo;
        }
        */
        public async Task<TodoModel> PutTodoAsync(int id,TodoModel todo)
        {
            
            todoContext.Entry(todo).State = EntityState.Modified;

                await todoContext.SaveChangesAsync();
            
            return todo;
        }
        
    }
}
