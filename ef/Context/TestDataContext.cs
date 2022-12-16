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
        public DbSet<SchoolClass> SchoolClasses { get; set; }

        public TestDataContext(DbContextOptions<TestDataContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.LogTo(Console.WriteLine);
            //optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // https://www.entityframeworktutorial.net/efcore
            // https://www.yogihosting.com/fluent-api-one-to-one-relationship-entity-framework-core/
            // https://www.youtube.com/watch?v=Zt4G9HB6-C4&ab_channel=CodeSemantic

            // one - one relationship
            modelBuilder.Entity<Teacher>()
                 .HasOne<Address>(teacher => teacher.TeacherAddress)
                 .WithOne()
                 .HasForeignKey<Teacher>(teacher => teacher.TeacherAddressId);

            modelBuilder.Entity<Student>()
                .HasOne<Address>(student => student.StudentAddress)
                .WithOne()
                .HasForeignKey<Student>(student => student.StudentAddressId);
           
            // one - many relationship
            modelBuilder.Entity<Student>()
                .HasOne<SchoolClass>(student => student.SchoolClassOfStudent)
                .WithMany(schoolClass => schoolClass.Students)
                .HasForeignKey(student => student.SchoolClassId);

            /*modelBuilder.Entity<SchoolClass>()
                .HasMany<Student>(scoolClass => scoolClass.Students)
                .WithOne(schoolClass => schoolClass.SchoolClassOfStudent)
                .HasForeignKey(student => student.SchoolClassId)
                .OnDelete(DeleteBehavior.Cascade);*/

                 
                    

            base.OnModelCreating(modelBuilder);
        }
    }
}
