using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Abby.EntityFrameworkCore
{
    public static class AbbyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbbyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbbyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
