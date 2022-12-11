using Microsoft.EntityFrameworkCore;

using EF.Models;

namespace EF.Server.Context
{
    public class TestDataContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherAddress> TeacherAddresses { get; set; }

        public TestDataContext(DbContextOptions<TestDataContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherAddress>()
                .HasOne(teacherAddress => teacherAddress.Teacher)
                .WithOne(teacher => teacher.TeacherAddress);

            modelBuilder.Entity<Teacher>()
                 .HasOne(teacher => teacher.TeacherAddress)
                 .WithOne(teacherAddress => teacherAddress.Teacher)
                 .HasForeignKey<Teacher>(teacher => teacher.TeacherAddressId);
            
            
                 
                    

            base.OnModelCreating(modelBuilder);
        }
    }
}
