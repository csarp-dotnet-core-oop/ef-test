using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    public class RepositoryWrapper
    {
        SubjectRepo subjectRepo;
        TeacherRepo teacherRepo;
        TeachTeacherSubjectRepo teachTeacherSubjectRepo;

        public SubjectRepo SubjectRepo { get => subjectRepo; set => subjectRepo = value; }
        public TeacherRepo TeacherRepo { get => teacherRepo; set => teacherRepo = value; }
        public TeachTeacherSubjectRepo TeachTeacherSubjectRepo { get => teachTeacherSubjectRepo; set => teachTeacherSubjectRepo = value; }

        public RepositoryWrapper()
        {
            subjectRepo = new SubjectRepo();
            teacherRepo = new TeacherRepo();
            teachTeacherSubjectRepo = new TeachTeacherSubjectRepo();
        }
    }
}
