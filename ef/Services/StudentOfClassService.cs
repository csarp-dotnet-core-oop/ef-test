using EF.Models;
using EF.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EF.Services
{
    public class StudentOfClassService
    {
        private RepositoryWrapper wrapper = new RepositoryWrapper();

        public StudentOfClassService()
        {                
        }

        public void StudentWithClass()
        {
            IQueryable<Student> students = wrapper.StudentRepo.GetAll().Include(student => student.SchoolClassOfStudent);

            Console.WriteLine("Diákok:");
            foreach (Student student in students.ToList())
            {
                Console.WriteLine($"{student.Id}.  {student.Name} {student.SchoolClassOfStudent.SchoolYear} {student.SchoolClassOfStudent.ClassType}");
            }

        }

        public void StudentOfClass()
        {
            List<SchoolClass> schoolClasses = wrapper.SchoolClassRepo
                .GetAll()
                .Include(schoolClass => schoolClass.Students)
                .ToList();

            Console.WriteLine("Diákok osztályonként:");
            foreach (SchoolClass schoolClass in schoolClasses) 
            {
                Console.WriteLine($"{schoolClass.Id}. -  {schoolClass.SchoolYear}.{schoolClass.ClassType} osztály: {schoolClass.Students.Count} fő.");
                foreach(Student student in schoolClass.Students )
                {
                    Console.WriteLine($"   {student.Id}.  {student.Name}");
                }
            }

        }
    }
}
