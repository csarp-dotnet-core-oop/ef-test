using Microsoft.EntityFrameworkCore;

using EF.Models;

namespace EF.Server.Context
{
    public class TestDataContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public TestDataContext(DbContextOptions<TestDataContext> options) : base(options)
        { 
        }
    }
}
