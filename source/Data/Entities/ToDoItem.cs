using Domain.Common;
using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class ToDoItem
        : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public Priority Priority { get; set; }
        public ToDoList List { get; set; }
        public DateTime Deadline { get; set; }
        public bool Completed { get; set; } = false;
    }
}