using Todo.Models;

namespace Todo.QueryStore
{
    public interface ITodoQueryStore
    {
        Task<IEnumerable<TodoModel>> GetTodosAsync();

        Task<TodoModel> PostTodoAsync(TodoModel todo);
    }
}
