using Todo.Models;
using Todo.QueryStore;

namespace Todo.Services
{
    public class TodoService: ITodoService
    {
        private readonly ITodoQueryStore _todoQueryStore;

        public TodoService(ITodoQueryStore todoQueryStore)
        {
            _todoQueryStore = todoQueryStore;
        }

        public async Task<IEnumerable<TodoModel>> GetTodosAsync()
        {
            //return new List<TodoModel>();
            return await _todoQueryStore.GetTodosAsync();
        }

        public async Task<TodoModel> PostTodosAsync(TodoModel todo)
        {
            return await _todoQueryStore.PostTodoAsync(todo);
        }

        public async Task<TodoModel> PutTodosAsync(int id,TodoModel todo)
        {
            return await _todoQueryStore.PutTodoAsync(id,todo);
        }
    }
}
