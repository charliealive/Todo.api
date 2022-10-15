using Microsoft.EntityFrameworkCore;

namespace Todo.Models
{
    public class TodoModel
    {
        //Indicate variables for DB
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

    }
}
