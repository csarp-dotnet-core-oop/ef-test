using EF.Models;
using EF.Repos;
using EF.Server.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    public class TeachTeacherSubjectRepo : RepositoryBase<TeachTeacherSubject>
    {
        private TestDataContext? testDataContext;

        public TeachTeacherSubjectRepo(TestDataContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeTestData();
        }

        public void MakeTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(1, 1));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(1, 2));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(1, 7));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(2, 3));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(2, 4));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(2, 10));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(3, 8));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(4, 2));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(5, 1));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(5, 8));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(5, 2));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(6, 1));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(6, 2));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(6, 7));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(7, 8));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(8, 10));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(8, 9));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(8, 3));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(9, 1));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(9, 7));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(9, 4));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(10, 3));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(10, 4));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(10, 1));
                testDataContext.TeachTeaherSubjects.Add(new TeachTeacherSubject(10, 8));
                testDataContext.SaveChanges();
            }
        }
    }
}


