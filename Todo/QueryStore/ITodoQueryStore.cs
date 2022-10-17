using Todo.Models;

namespace Todo.QueryStore
{
    public interface ITodoQueryStore
    {
        Task<IEnumerable<TodoModel>> GetTodosAsync();

        Task<IEnumerable<TodoModel>> PostTodosAsync(TodoModel todo);
    }
}
