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
    public class AddressRepo : RepositoryBase<Address>
    {
        private TestDataContext context;
        public AddressRepo(TestDataContext context) 
            : base(context)
        {
            this.context = context;
            MakeTestData();
        }

        private void MakeTestData()
        {
            context.Addresses.Add(new Address(1, "Valami utca 1.","Varos",1000));
            context.Addresses.Add(new Address(1, "Valami utca 2.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 3.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 4.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 5.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 6.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 7.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 8.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 9.", "Varos", 1000));
            context.Addresses.Add(new Address(1, "Valami utca 10.", "Varos", 1000));
            context.SaveChanges();
        }
    }
}
