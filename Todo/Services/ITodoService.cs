using Todo.Models;

namespace Todo.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoModel>> GetTodosAsync();

        Task<IEnumerable<TodoModel>> PostTodosAsync();

    }
}