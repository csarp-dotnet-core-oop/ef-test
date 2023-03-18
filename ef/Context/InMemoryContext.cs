﻿using EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Context
{
    public class InMemoryContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<TypeOfSubject> TypeOfSubjects { get; set; }
        public DbSet<TeachTeacherSubject> TeachTeaherSubjects { get; set; }
        public DbSet<TeachTeacherSchoolClass> TeachTeacherSchoolClasses { get; set; }

        public InMemoryContext(DbContextOptions<InMemoryContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
            modelBuilder.Entity<TeachTeacherSchoolClass>()
                .HasKey(tts => new { tts.TeacherId, tts.SchoolClassId});       


            modelBuilder.Entity<TeachTeacherSubject>()
                .HasOne<Teacher>(tts => tts.Techher)
                .WithMany()
                .HasForeignKey(tts => tts.TeacherId);

            modelBuilder.Entity<TeachTeacherSubject>()
                .HasOne<Subject>(tts => tts.Subject)
                .WithMany()
                .HasForeignKey(tts => tts.SubjectId);

        }
    }
}