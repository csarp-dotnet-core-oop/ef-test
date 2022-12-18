using EF.Models;
using EF.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Services
{
    public class OneOneAddressService
    {
        private RepositoryWrapper wrapper = new RepositoryWrapper();

        public OneOneAddressService()
        {
        }

        public void TeacherAndAddress()
        {
            List<Teacher> teachers = wrapper.TeacherRepo.GetAll().Include(teacher => teacher.TeacherAddress).ToList();
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine($"Tanár: {teacher.Id} {teacher.Name} {teacher.TeacherAddress.StreetNumber} { teacher.TeacherAddress.City}");
            }
        }

        public void StudentAndAddress()
        {
            List<Student> students = wrapper.StudentRepo.GetAll().Include(student => student.StudentAddress).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"Tanár: {student.Id} {student.Name} {student.StudentAddress.StreetNumber} {student.StudentAddress.City}");
            }
        }
    }
}
