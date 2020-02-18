using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FE-practice.Authorization.Roles;
using FE-practice.Authorization.Users;
using FE-practice.MultiTenancy;

namespace FE-practice.EntityFrameworkCore
{
    public class FE-practiceDbContext : AbpZeroDbContext<Tenant, Role, User, FE-practiceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FE-practiceDbContext(DbContextOptions<FE-practiceDbContext> options)
            : base(options)
        {
        }
    }
}
