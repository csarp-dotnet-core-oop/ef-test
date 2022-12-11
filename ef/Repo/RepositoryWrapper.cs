using EF.Server.Context;
using Microsoft.EntityFrameworkCore;
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

        public static DbContextOptions<TestDataContext> contextOptions = new DbContextOptionsBuilder<TestDataContext>()
                                        .UseInMemoryDatabase(databaseName: "KretaContext" + Guid.NewGuid().ToString())
                                        .Options;

        public RepositoryWrapper()
        {
            TestDataContext context = new TestDataContext(contextOptions);

            subjectRepo = new SubjectRepo(context);
            teacherRepo = new TeacherRepo(context);
            teachTeacherSubjectRepo = new TeachTeacherSubjectRepo();
        }
    }
}
