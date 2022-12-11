using EF.Models;
using EF.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Services
{
    public class TeacherAddressService
    {
        RepositoryWrapper wrapper = new RepositoryWrapper();

        public TeacherAddressService()
        {
        }

        public void TeacherAndAddress()
        {
            List<Teacher> teachers = wrapper.TeacherRepo.GetAll().ToList();
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine($"Tanár: {teacher.Id} {teacher.Name} {teacher.TeacherAddress.StreetNumber} { teacher.TeacherAddress.City}");
            }
        }
    }
}
