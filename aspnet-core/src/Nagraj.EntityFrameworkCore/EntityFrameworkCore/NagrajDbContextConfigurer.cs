using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Nagraj.EntityFrameworkCore
{
    public static class NagrajDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NagrajDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NagrajDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
