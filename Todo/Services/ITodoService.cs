using Todo.Models;

namespace Todo.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoModel>> GetTodosAsync();

        Task<TodoModel> PostTodosAsync(TodoModel todo);

        Task<TodoModel> PutTodosAsync(int id,TodoModel todo);

        Task<TodoModel> DeleteTodosAsync(int id);
    }
}