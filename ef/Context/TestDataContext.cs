using Microsoft.EntityFrameworkCore;

using EF.Models;

namespace EF.Server.Context
{
    public class TestDataContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Student> Students { get; set; }

        public TestDataContext(DbContextOptions<TestDataContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // https://www.yogihosting.com/fluent-api-one-to-one-relationship-entity-framework-core/
            // https://www.youtube.com/watch?v=Zt4G9HB6-C4&ab_channel=CodeSemantic

            /*modelBuilder.Entity<Teacher>()
                .HasKey(teacher => teacher.Id);*/
            /*modelBuilder.Entity<TeacherAddress>()
                .HasKey(address => address.Id);*/


            modelBuilder.Entity<Teacher>()
                 .HasOne<Address>(teacher => teacher.TeacherAddress)
                 .WithOne()
                 .HasForeignKey<Teacher>(teacher => teacher.TeacherAddressId);

            modelBuilder.Entity<Student>()
                .HasOne<Address>(student => student.StudentAddress)
                .WithOne()
                .HasForeignKey<Student>(student => student.StudentAddressId);

            
                 
                    

            base.OnModelCreating(modelBuilder);
        }
    }
}
