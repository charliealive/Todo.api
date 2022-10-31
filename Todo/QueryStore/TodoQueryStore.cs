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

        public async Task<TodoModel> PutTodoAsync(int id, TodoModel todo)
        {

            todoContext.Entry(todo).State = EntityState.Modified;

            await todoContext.SaveChangesAsync();

            return todo;
        }

        public async Task<TodoModel> DeleteTodoAsync(int id)
        {
            var todo = await todoContext.Todos.FindAsync(id);
            todoContext.Todos.Remove(todo);
            await todoContext.SaveChangesAsync();
            return null;
            
        }
        /*
        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoModel>> DeleteTodo(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if( todo == null)
            {
                return NotFound();
            }

            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
    }
}
