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
    public class TeachTeacherSchoolClassRepo : RepositoryBase<TeachTeacherSchoolClass>
    {
        private TestDataContext? testDataContext;

        public TeachTeacherSchoolClassRepo(TestDataContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeTestData();
        }

        public void MakeTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(1, 1));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(2, 2));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(3, 7));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(4, 3));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(5, 4));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(3, 6));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(2, 4));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(1, 2));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(5, 1));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(7, 2));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(8, 2));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(9, 1));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(10, 2));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(10, 3));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(2, 5));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(8, 6));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(9, 7));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(4, 3));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(7, 1));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(4, 7));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(8, 4));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(4, 3));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(9, 4));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(3, 1));
                testDataContext.TeachTeacherSchoolClasses.Add(new TeachTeacherSchoolClass(2, 2));
                testDataContext.SaveChanges();
            }
        }
    }
}


