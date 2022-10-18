using Todo.Models;

namespace Todo.QueryStore
{
    public interface ITodoQueryStore<T>
    {
        Task<IEnumerable<TodoModel>> GetTodosAsync();

        Task<IEnumerable<TodoModel>> PostTodosAsync(T todo);
    }
}
