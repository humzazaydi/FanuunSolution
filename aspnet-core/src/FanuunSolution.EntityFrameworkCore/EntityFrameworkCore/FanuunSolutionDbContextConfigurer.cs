using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FanuunSolution.EntityFrameworkCore
{
    public static class FanuunSolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FanuunSolutionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FanuunSolutionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
