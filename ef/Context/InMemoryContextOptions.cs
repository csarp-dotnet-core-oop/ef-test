using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Context
{
    public static class InMemoryContextOptions
    {
        public static DbContextOptions<InMemoryContext> contextOptions = new DbContextOptionsBuilder<InMemoryContext>()
            .UseInMemoryDatabase(databaseName: "KretaTest" + Guid.NewGuid().ToString())
            .Options;
    }
}
