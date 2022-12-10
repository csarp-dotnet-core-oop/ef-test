using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EF.Repo;

namespace EF.Services
{
    class TeacherService
    {
        public TeacherRepo teacherRepo = new TeacherRepo();

        public TeacherService()
        {            
        }

        // Osztályfőnökök nevei
        public void HeadTeachersName()
        {
            List<string> headTeacher = (from teacher in teacherRepo.Teachers
                                        where teacher.IsHeadTeacher
                                        select teacher.Name).ToList();
            Console.WriteLine("Osztályfőnökök:");
            foreach(string name in headTeacher)
            {
                Console.WriteLine($"{name}");
            }

        }

        public void HeadTeachersLambda()
        {
            List<string> headTeacher = teacherRepo.Teachers.Where(teacher => teacher.IsHeadTeacher).Select(teacher => teacher.Name).ToList();
            Console.WriteLine("Osztályfőnökök:");
            foreach (string name in headTeacher)
            {
                Console.WriteLine($"{name}");
            }
        }

        // Hölgy tanárok id-je és nevei
        public void WomanTeacher()
        {
            var womanTeacher = from teacher in teacherRepo.Teachers
                               where teacher.IsWoman
                               select new
                               {
                                   Id = teacher.Id,
                                   Name = teacher.Name
                               };

            Console.WriteLine("Höly tanárok:");
            foreach(var teacher in womanTeacher)
            {
                Console.WriteLine($"{teacher.Id} -> {teacher.Name}");
            }
        }

        public void WomanTeacherLambda()
        {
            var womanTeacher = teacherRepo.Teachers.Where(teacher => teacher.IsWoman).Select(teacher => new {Id = teacher.Id,Name=teacher.Name}).ToList();

            Console.WriteLine("Höly tanárok:");
            foreach (var teacher in womanTeacher)
            {
                Console.WriteLine($"{teacher.Id} -> {teacher.Name}");
            }
        }

        // Számozás és új adat
        public void WomanTeacherIndex()
        {
            var womanTeacher = from teacher in teacherRepo.Teachers.Select((value,index) => new {value, index})
                               where teacher.value.IsWoman
                               select new
                               {
                                   IndexPosition = teacher.index,
                                   Id = teacher.value.Id,
                                   NewName = teacher.value.Name + " tanár nő!"
                               };

            Console.WriteLine("Höly tanárok:");
            foreach (var teacher in womanTeacher)
            {
                Console.WriteLine($"{teacher.IndexPosition}. {teacher.Id} -> {teacher.NewName}");
            }
        }


        // Számozás és új adat
        public void WomanTeacherIndexLambda()
        {
            var womanTeacher = teacherRepo.Teachers.Where(teacher => teacher.IsWoman)
                .Select((teacher, index) => new
                {
                    IndexPosition = index,
                    Id = teacher.Id,
                    NewName = teacher.Name + " tanár nő!"
                });


            Console.WriteLine("Höly tanárok és sorszámaok:");
            foreach (var teacher in womanTeacher)
            {
                Console.WriteLine($"{teacher.IndexPosition}. {teacher.Id} -> {teacher.NewName}");
            }
        }
    }
}
