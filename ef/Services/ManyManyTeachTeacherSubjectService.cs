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
    public class ManyManyTeachTeacherSubjectService
    {
        private RepositoryWrapper wrapper;

        public ManyManyTeachTeacherSubjectService()
        {
            wrapper = new RepositoryWrapper();
        }

        public void TeacherSubjectPair()
        {
            IQueryable<TeachTeacherSubject> result = wrapper.TeachTeacherSubjectRepo
                .GetAll()
                .Include(tts => tts.Subject)
                .Include(tts => tts.Techher);

            foreach(TeachTeacherSubject tts in result.ToList())
            {
                Console.WriteLine($"{tts.Techher.Name} -> {tts.Subject.Name}");
            }

        }
    }
}
