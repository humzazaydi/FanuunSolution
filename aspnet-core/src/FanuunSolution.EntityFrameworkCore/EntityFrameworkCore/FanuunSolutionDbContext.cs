using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FanuunSolution.Authorization.Roles;
using FanuunSolution.Authorization.Users;
using FanuunSolution.MultiTenancy;

namespace FanuunSolution.EntityFrameworkCore
{
    public class FanuunSolutionDbContext : AbpZeroDbContext<Tenant, Role, User, FanuunSolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FanuunSolutionDbContext(DbContextOptions<FanuunSolutionDbContext> options)
            : base(options)
        {
        }
    }
}
