using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Vishnu_MyProject.EntityFrameworkCore
{
    public static class Vishnu_MyProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Vishnu_MyProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Vishnu_MyProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
