using EF.Context;
using EF.Models;
using EF.Repos;

namespace EF.Repo
{
   public class AddressRepo : RepositoryBase<Address>
    {
        private InMemoryContext context;

        public AddressRepo(InMemoryContext context) 
            : base(context)
        {
            this.context = context;
            MakeTestData();
        }

        private void MakeTestData()
        {
            context.Addresses.Add(new Address(1, "Valami utca 1.","Varos",1000));
            context.Addresses.Add(new Address(2, "Valami utca 2.", "Varos", 1000));
            context.Addresses.Add(new Address(3, "Valami utca 3.", "Varos", 1000));
            context.Addresses.Add(new Address(4, "Valami utca 4.", "Varos", 1000));
            context.Addresses.Add(new Address(5, "Valami utca 5.", "Varos", 1000));
            context.Addresses.Add(new Address(6, "Valami utca 6.", "Varos", 1000));
            context.Addresses.Add(new Address(7, "Valami utca 7.", "Varos", 1000));
            context.Addresses.Add(new Address(8, "Valami utca 8.", "Varos", 1000));
            context.Addresses.Add(new Address(9, "Valami utca 9.", "Varos", 1000));
            context.Addresses.Add(new Address(10, "Valami utca 10.", "Varos", 1000));
            context.Addresses.Add(new Address(11, "Valami utca 11.", "Varos", 1000));
            context.Addresses.Add(new Address(12, "Valami utca 12.", "Varos", 1000));
            context.Addresses.Add(new Address(13, "Valami utca 13.", "Varos", 1000));
            context.Addresses.Add(new Address(14, "Valami utca 14.", "Varos", 1000));
            context.Addresses.Add(new Address(15, "Valami utca 15.", "Varos", 1000));
            context.Addresses.Add(new Address(16, "Valami utca 16.", "Varos", 1000));
            context.Addresses.Add(new Address(17, "Valami utca 17.", "Varos", 1000));
            context.Addresses.Add(new Address(18, "Valami utca 10.", "Varos", 1000));
            context.Addresses.Add(new Address(19, "Valami utca 19.", "Varos", 1000));
            context.Addresses.Add(new Address(20, "Valami utca 20.", "Varos", 1000));
            context.SaveChanges();
        }
    }
}
