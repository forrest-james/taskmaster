using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ToDoList
        : AuditableEntity
    {
        public ToDoList() => Items = new HashSet<ToDoItem>();

        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<ToDoItem> Items { get; set; }
    }
}