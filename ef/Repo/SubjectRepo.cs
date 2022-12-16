using EF.Models;
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
    public class SubjectRepo : RepositoryBase<Subject>
    {
        TestDataContext? testDataContext = null;
        public SubjectRepo(TestDataContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeSubjectTestData();
        }
    

        public void MakeSubjectTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.Subjects.Add(new Subject(1, "Matematika"));
                testDataContext.Subjects.Add(new Subject(2, "Magyar nyelv"));
                testDataContext.Subjects.Add(new Subject(3, "Irodalom"));
                testDataContext.Subjects.Add(new Subject(4, "Angol nyelv"));
                testDataContext.Subjects.Add(new Subject(5, "Német nyelv"));
                testDataContext.Subjects.Add(new Subject(6, "Történelem"));
                testDataContext.Subjects.Add(new Subject(7, "Rajz"));
                testDataContext.Subjects.Add(new Subject(8, "Testnevelés"));
                testDataContext.Subjects.Add(new Subject(9, "Fizika"));
                testDataContext.Subjects.Add(new Subject(10, "Kémia"));
                testDataContext.SaveChanges();
            }
        }
    }
}

