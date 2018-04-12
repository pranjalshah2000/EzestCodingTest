using EzestCodingTest.DAL.Migrations;
using EzestCodingTest.DAL.Models;
using System.Data.Entity;

namespace EzestCodingTest.DAL
{
    public class EzestCodingTestDBContext : DbContext
    {
        public EzestCodingTestDBContext() : base("EzestCodingTestDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EzestCodingTestDBContext, Configuration>("EzestCodingTestDB"));
        }

        public virtual DbSet<User> Users { get; set; }
    }
}

