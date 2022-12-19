using EF.Server.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    public class RepositoryWrapper
    {
        private SubjectRepo? subjectRepo = null;
        private TeacherRepo? teacherRepo = null;
        private AddressRepo? addressRepo = null;
        private StudentRepo? studentRepo = null;
        private SchoolClassRepo? schoolClassRepo = null;
        private TypeOfSubjectRepo? typeOfSubjectRepo = null;
        private TeachTeacherSubjectRepo? teachTeacherSubjectRepo = null;
        private TeachTeacherSchoolClassRepo? teachTeacherSchoolClassRepo = null;

        public SubjectRepo SubjectRepo { get => subjectRepo; set => subjectRepo = value; }
        public TeacherRepo TeacherRepo { get => teacherRepo; set => teacherRepo = value; }
        public StudentRepo StudentRepo { get => studentRepo; set => studentRepo = value; }
        public SchoolClassRepo SchoolClassRepo { get => schoolClassRepo; set => schoolClassRepo = value; }
        public TypeOfSubjectRepo TypeOfSubjectRepo { get => typeOfSubjectRepo; set => typeOfSubjectRepo = value; }
        public TeachTeacherSubjectRepo TeachTeacherSubjectRepo { get => teachTeacherSubjectRepo; set => teachTeacherSubjectRepo = value; }
        public TeachTeacherSchoolClassRepo TeachTeacherSchoolClass { get => teachTeacherSchoolClassRepo; set =>teachTeacherSchoolClassRepo= value; }

        

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
            if (typeOfSubjectRepo == null)
                typeOfSubjectRepo = new TypeOfSubjectRepo(context);
            if (teachTeacherSubjectRepo == null)
                teachTeacherSubjectRepo = new TeachTeacherSubjectRepo(context);
            if (teachTeacherSchoolClassRepo == null)
                teachTeacherSchoolClassRepo = new TeachTeacherSchoolClassRepo(context);
        }
    }
}
