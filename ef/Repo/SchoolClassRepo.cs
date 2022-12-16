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
    public class SchoolClassRepo : RepositoryBase<SchoolClass>
    {
        TestDataContext? testDataContext = null;
        public SchoolClassRepo(TestDataContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeSubjectTestData();
        }
    

        public void MakeSubjectTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.SchoolClasses.Add(new SchoolClass(1, 9, 'a',1));
                testDataContext.SchoolClasses.Add(new SchoolClass(2, 9, 'b', 1));
                testDataContext.SchoolClasses.Add(new SchoolClass(3, 9, 'c', 1));
                testDataContext.SchoolClasses.Add(new SchoolClass(4, 10, 'a', 1));
                testDataContext.SchoolClasses.Add(new SchoolClass(5, 10, 'b', 1));
                testDataContext.SchoolClasses.Add(new SchoolClass(6, 10, 'c', 1));
                testDataContext.SchoolClasses.Add(new SchoolClass(7, 11, 'a', 1));                
                testDataContext.SaveChanges();
            }
        }
    }
}

