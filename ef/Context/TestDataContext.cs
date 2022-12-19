using EF.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.Server.Context
{
    public class TestDataContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<TypeOfSubject> TypeOfSubjects { get; set; }
        public DbSet<TeachTeacherSubject> TeachTeaherSubjects { get; set; }
        public DbSet<TeachTeacherSchoolClass> TeachTeacherSchoolClasses { get; set }

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
            // https://www.entityframeworktutorial.net/efcore/configure-one-to-one-relationship-using-fluent-api-in-ef-core.aspx
            // https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx
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


            // many - many ralition ship
            modelBuilder.Entity<TeachTeacherSubject>()
                .HasKey(tts => new { tts.SubjectId, tts.TeacherId });

            modelBuilder.Entity<TeachTeacherSubject>()
                .HasOne<Teacher>(tts => tts.Techher)
                .WithMany()
                .HasForeignKey(tts => tts.TeacherId);

            modelBuilder.Entity<TeachTeacherSubject>()
                .HasOne<Subject>(tts => tts.Subject)
                .WithMany()
                .HasForeignKey(tts => tts.SubjectId);                                  

            base.OnModelCreating(modelBuilder);
        }
    }
}
