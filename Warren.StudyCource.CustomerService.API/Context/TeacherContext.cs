using Microsoft.EntityFrameworkCore;
using Warren.StudyCource.CustomerService.API.Models;

namespace Warren.StudyCource.CustomerService.API.Context
{
    public class TeacherContext : DbContext
    {
        public TeacherContext(DbContextOptions<TeacherContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Teacher>()
                .ToTable("Teacher")
                .HasKey(c => c.Id);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
