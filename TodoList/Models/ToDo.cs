using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
    public class ToDo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool Complete { get; set; }
        public string Author { get; set; }
    }

    public class ToDoDBContext : DbContext
    {
        public ToDoDBContext() : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<TodoList.Models.ToDo> ToDoes { get; set; }
    }


}