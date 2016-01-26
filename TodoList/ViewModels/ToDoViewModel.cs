using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.ViewModels
{
    public class ToDoViewModel
    {
        public ToDoViewModel()
        {
            toDo = new ToDo();
            toDoFilterItems = new List<SelectListItem>();       //Drop down list

            toDoFilterItems.Add(new SelectListItem { Text = "Complete", Value = "Complete" });
            toDoFilterItems.Add(new SelectListItem { Text = "Todo", Value = "Todo" });
            toDoFilterItems.Add(new SelectListItem { Text = "Show all", Value = "Show all" });
         
        }
        public IEnumerable<ToDo> ToDoes { get; set; }
        public List<SelectListItem> toDoFilterItems { get; set; }
        public string toDoFilterItem { get; set; }
        public ToDo toDo { get;set;}
    }
}