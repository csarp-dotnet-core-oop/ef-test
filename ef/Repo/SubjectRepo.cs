using EF.Context;
using EF.Models;
using EF.Models;
using EF.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    public class SubjectRepo : RepositoryBase<Subject>
    {


        InMemoryContext? testDataContext = null;
        public SubjectRepo(InMemoryContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeSubjectTestData();
        }
    

        public void MakeSubjectTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.Subjects.Add(new Subject(1, "Matematika",1));
                testDataContext.Subjects.Add(new Subject(2, "Magyar nyelv",2));
                testDataContext.Subjects.Add(new Subject(3, "Irodalom",2));
                testDataContext.Subjects.Add(new Subject(4, "Angol nyelv", 2));
                testDataContext.Subjects.Add(new Subject(5, "Német nyelv", 2));
                testDataContext.Subjects.Add(new Subject(6, "Történelem",3));
                testDataContext.Subjects.Add(new Subject(7, "Rajz", 4));
                testDataContext.Subjects.Add(new Subject(8, "Testnevelés",1));
                testDataContext.Subjects.Add(new Subject(9, "Fizika", 1));
                testDataContext.Subjects.Add(new Subject(10, "Kémia",1));
                testDataContext.Subjects.Add(new Subject(11, "Zene",4));
                testDataContext.Subjects.Add(new Subject(12, "Biológia",2));
                testDataContext.SaveChanges();
            }
        }
    }
}

