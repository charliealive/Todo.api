﻿using Microsoft.EntityFrameworkCore;
namespace Todo.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoModel> Todos { get; set; }
    }
}
