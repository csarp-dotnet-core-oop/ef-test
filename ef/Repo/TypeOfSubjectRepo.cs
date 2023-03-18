using EF.Context;
using EF.Models;
using EF.Repos;

namespace EF.Repo
{
    public class TypeOfSubjectRepo : RepositoryBase<TypeOfSubject>
    {
        InMemoryContext? testDataContext = null;
        public TypeOfSubjectRepo(InMemoryContext testDataContext) : base(testDataContext)
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

