using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abby.Authorization.Roles;
using Abby.Authorization.Users;
using Abby.MultiTenancy;

namespace Abby.EntityFrameworkCore
{
    public class AbbyDbContext : AbpZeroDbContext<Tenant, Role, User, AbbyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbbyDbContext(DbContextOptions<AbbyDbContext> options)
            : base(options)
        {
        }
    }
}
