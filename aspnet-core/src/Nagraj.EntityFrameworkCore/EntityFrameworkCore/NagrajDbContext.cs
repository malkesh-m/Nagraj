using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Nagraj.Authorization.Roles;
using Nagraj.Authorization.Users;
using Nagraj.Contacts;
using Nagraj.MultiTenancy;

namespace Nagraj.EntityFrameworkCore
{
    public class NagrajDbContext : AbpZeroDbContext<Tenant, Role, User, NagrajDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Contact> Contacts { get; set; }
        public NagrajDbContext(DbContextOptions<NagrajDbContext> options)
            : base(options)
        {
        }
    }
}
