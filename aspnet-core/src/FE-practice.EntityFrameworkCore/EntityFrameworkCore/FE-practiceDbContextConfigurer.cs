using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FE-practice.EntityFrameworkCore
{
    public static class FE-practiceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FE-practiceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FE-practiceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
