using EF.Models.DTO;
using EF.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Services
{
    // https://dotnettutorials.net/lesson/introduction-to-linq/
    public class TeachTeacherSubjectService
    {
        private RepositoryWrapper wrapper;

        public TeachTeacherSubjectService()
        {
            wrapper = new RepositoryWrapper();
        }

        // 1. feladat
        // Tanár tantárgy párok
        public void TeacherSubjectPair()
        {
            List<TeacherSubjectPair> result = (from teacher in wrapper.TeacherRepo.GetAll()
                                               from subject in wrapper.SubjectRepo.GetAll()
                                               orderby teacher.Name
                                               select new TeacherSubjectPair
                                               {
                                                   Teacher = teacher.Name,
                                                   Subject = subject.Name                                            
                                               }).ToList();

            Console.WriteLine("Tanár - tantárgy párok:");
            foreach (TeacherSubjectPair pair in result)
                Console.WriteLine($"{pair.Teacher} => {pair.Subject}");
        }

        public void TeacherSubjectPairLinq()
        {
            var result = wrapper.TeacherRepo.GetAll().SelectMany(
                    teacher => wrapper.SubjectRepo.GetAll(), (teacher, subject) => new TeacherSubjectPair
                    {
                        Teacher = teacher.Name,
                        Subject = subject.Name
                    }).OrderBy(pair => pair.Teacher).ToList();
                                     

            Console.WriteLine("Tanár - tantárgy párok:");
            foreach (TeacherSubjectPair pair in result)
                Console.WriteLine($"{pair.Teacher} => {pair.Subject}");
        }

        // 2. feladat
        // Ki melyik tantárgyat tanítja
        public void TeacherTeachSubjects()
        {
            List<TeacherSubjectPair> result = (from teacher in wrapper.TeacherRepo.GetAll()
                                               from subject in wrapper.SubjectRepo.GetAll()
                                               from teaching in wrapper.TeachTeacherSubjectRepo.Teachings
                                               where teaching.TeacherId==teacher.Id && teaching.SubjectId==subject.Id
                                               orderby teacher.Name
                                               select new TeacherSubjectPair
                                               {
                                                   Teacher = teacher.Name,
                                                   Subject = subject.Name
                                               }).ToList();

            Console.WriteLine("Ki melyik tantárgyat tanítja:");
            foreach (TeacherSubjectPair pair in result)
                Console.WriteLine($"{pair.Teacher} => {pair.Subject}");
        }

        // 3. feladat
        // Tantárgyanként hány tanító tanár van
        public void NumberOfTeacherPerSubject()
        {
            Dictionary<String, int> result = (from teacher in wrapper.TeacherRepo.GetAll()
                                              from subject in wrapper.SubjectRepo.GetAll()
                                              from teaching in wrapper.TeachTeacherSubjectRepo.Teachings
                                              where teaching.TeacherId == teacher.Id && teaching.SubjectId == subject.Id
                                              group teacher by teacher.Name into teacherGroup
                                              select new TeacherNumberPair
                                              {
                                                  Teacher = teacherGroup.Key,
                                                  Count = teacherGroup.Count()
                                              }

                                            ).ToDictionary(t => t.Teacher, t => t.Count);
            foreach(KeyValuePair<string,int> pair in result)
            {
                Console.WriteLine($"{ pair.Key} => {pair.Value}");
            }
        }

    }
}
