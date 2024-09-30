using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using TaskManagement.Models;

namespace TaskManagement.Data
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext(DbContextOptions<TaskManagementContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TaskNote> TaskNotes { get; set; }
        public DbSet<Documents> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure relationships and constraints here if necessary
        }
    }

}
