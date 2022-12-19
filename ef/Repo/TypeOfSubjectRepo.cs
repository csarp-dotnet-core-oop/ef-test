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
    public class TypeOfSubjectRepo : RepositoryBase<TypeOfSubject>
    {
        TestDataContext? testDataContext = null;
        public TypeOfSubjectRepo(TestDataContext testDataContext) : base(testDataContext)
        {
            this.testDataContext = testDataContext;
            MakeSubjectTestData();
        }
    

        public void MakeSubjectTestData()
        {
            if (testDataContext != null)
            {
                testDataContext.TypeOfSubjects.Add(new TypeOfSubject(1, "Természettudomány"));
                testDataContext.TypeOfSubjects.Add(new TypeOfSubject(2, "Nyelv és idegen nyelv"));
                testDataContext.TypeOfSubjects.Add(new TypeOfSubject(3, "Társadalomtuduomány"));
                testDataContext.TypeOfSubjects.Add(new TypeOfSubject(4, "Művészet"));

                testDataContext.SaveChanges();
            }
        }
    }
}

