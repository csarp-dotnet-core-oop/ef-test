using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Context;
using EF.Models;
using EF.Repos;

namespace EF.Repo
{
    public class StudentRepo : RepositoryBase<Student>
    {

        private InMemoryContext? testDataContext;
        public StudentRepo(InMemoryContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeTestData();
        }

        public void MakeTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.Students.Add(new Student(1, "Felelő Feri", 1,12));
                testDataContext.Students.Add(new Student(2, "Jegyíró János", 1,11));
                testDataContext.Students.Add(new Student(3, "Író Ilon", 1,13));
                testDataContext.Students.Add(new Student(4, "Számoló Szinti", 2,14));
                testDataContext.Students.Add(new Student(5, "Ugrató Ulrich", 2,15));
                testDataContext.Students.Add(new Student(6, "Reszkess Richárd", 2,16));
                testDataContext.Students.Add(new Student(7, "Alkotó Aliz", 2,17));
                testDataContext.Students.Add(new Student(8, "Német Nelli", 3,18));
                testDataContext.Students.Add(new Student(9, "Megértő Mari", 3,19));
                testDataContext.Students.Add(new Student(10, "Felelő Fanni", 3,20));
                testDataContext.SaveChanges();
            }
        }
    }
}
