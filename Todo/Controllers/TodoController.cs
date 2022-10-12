using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todo.Models;
using Todo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        
        private readonly ITodoService _todoService;
        //Calling service
        public TodoController(ITodoService todoService)
        {
          
            _todoService = todoService;
        }

        // GET: api/<TodoController>
        [HttpGet]
        //Collect result of service
        public async Task<ActionResult<IEnumerable<TodoModel>>> GetTodo()
        {
            return Ok(await _todoService.GetTodosAsync());
        }

        // GET api/<TodoController>/5


        //[HttpGet("{id}")]

        /*public async Task<ActionResult<TodoModel>> GetTodoid(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if(todo == null)
            {
                return NotFound();
            }
            return todo;
        }

        // POST api/<TodoController>
        [HttpPost]
        public async Task<ActionResult<TodoModel>> PostTodo(TodoModel todo)
        {
            _context.Todos.Add(todo); 
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoid", new { id = todo.Id }, todo);
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<TodoModel>> PutTodo(int id, TodoModel todo)
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
        private bool TodoExists(int id)
        {
            return _context.Todos.Any(t => t.Id == id);
        }*/
    }
}
