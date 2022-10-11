using Moq;
using Todo.Models;
using Todo.QueryStore;
using Todo.Services;
using Xunit;

namespace Todo.Test
{
    public class TodoServiceTest
    {
        [Fact]
            public async Task GetToDoReturnListOfToDo()
        {
            //Arrange 
            var mocktodoQueryStore = new Mock<ITodoQueryStore>();
            mocktodoQueryStore.Setup((e) => e.GetTodosAsync()).ReturnsAsync(new List<TodoModel> { new TodoModel {
                Id = 1,
                Title = "codingaaaa",
                Completed = true,
            } });
            var todoService = new TodoService(mocktodoQueryStore.Object);
            //Act
            var result = await todoService.GetTodosAsync();
            //Assert
            mocktodoQueryStore.VerifyAll();
            Assert.Single(result);
            Assert.Collection(result, (todo) => { Assert.Equal(1, todo.Id); Assert.Equal("codingaaaa", todo.Title); Assert.True(todo.Completed); });
        }
    }
}