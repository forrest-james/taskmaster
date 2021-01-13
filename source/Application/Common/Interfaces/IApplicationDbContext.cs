using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<JobApplication> JobApplications { get; set; }
        DbSet<ToDoList> ToDoLists { get; set; }
        DbSet<ToDoItem> ToDoItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}