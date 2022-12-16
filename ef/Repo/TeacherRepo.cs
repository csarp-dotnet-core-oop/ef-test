using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EF.Models;
using EF.Repos;
using EF.Server.Context;

namespace EF.Repo
{
    public class TeacherRepo : RepositoryBase<Teacher>
    {

        private TestDataContext? testDataContext;
        public TeacherRepo(TestDataContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeTestData();
        }

        public void MakeTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.Teachers.Add(new Teacher(1, "Feldolgozó Feri", true, false,2));
                testDataContext.Teachers.Add(new Teacher(2, "Jegyölő János", false, false,1));
                testDataContext.Teachers.Add(new Teacher(3, "Olvasó Olga", true, true,3));
                testDataContext.Teachers.Add(new Teacher(4, "Számoló Szonja", true, true,4));
                testDataContext.Teachers.Add(new Teacher(5, "Utazó Ulrich", false, false,5));
                testDataContext.Teachers.Add(new Teacher(6, "Részeg Richárd", true, false,6));
                testDataContext.Teachers.Add(new Teacher(7, "Álmodozó Aliz", true, true,7));
                testDataContext.Teachers.Add(new Teacher(8, "Nagy Nelli", false, true,8));
                testDataContext.Teachers.Add(new Teacher(9, "Megértő Margit", true, true,9));
                testDataContext.Teachers.Add(new Teacher(10, "Fuldokló Fanni", true, true,10));
                testDataContext.SaveChanges();
            }
        }
    }
}
