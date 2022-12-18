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
        SubjectRepo? subjectRepo=null;
        TeacherRepo? teacherRepo=null;
        AddressRepo? addressRepo = null;
        StudentRepo? studentRepo = null;
        SchoolClassRepo? schoolClassRepo = null;
        TeachTeacherSubjectRepo? teachTeacherSubjectRepo=null;

        public SubjectRepo SubjectRepo { get => subjectRepo; set => subjectRepo = value; }
        public TeacherRepo TeacherRepo { get => teacherRepo; set => teacherRepo = value; }
        public StudentRepo StudentRepo { get => studentRepo; set => studentRepo = value; }
        public SchoolClassRepo SchoolClassRepo { get => schoolClassRepo; set => schoolClassRepo = value; }

        public TeachTeacherSubjectRepo TeachTeacherSubjectRepo { get => teachTeacherSubjectRepo; set => teachTeacherSubjectRepo = value; }

        
        public static DbContextOptions<TestDataContext> contextOptions = new DbContextOptionsBuilder<TestDataContext>()
                                        .UseInMemoryDatabase(databaseName: "KretaDb" + Guid.NewGuid().ToString())
                                        .Options;

        public RepositoryWrapper()
        {
            TestDataContext context = new TestDataContext(contextOptions);

            if (subjectRepo==null)
                subjectRepo = new SubjectRepo(context);
            if (teacherRepo==null)
                teacherRepo = new TeacherRepo(context);
            if (addressRepo==null)
                addressRepo = new AddressRepo(context);
            if (studentRepo == null)
                studentRepo = new StudentRepo(context);
            if (schoolClassRepo == null)
                schoolClassRepo = new SchoolClassRepo(context);
            if (TeachTeacherSubjectRepo == null)
                teachTeacherSubjectRepo = new TeachTeacherSubjectRepo(context);
            
            //teachTeacherSubjectRepo = new TeachTeacherSubjectRepo();
        }
    }
}
