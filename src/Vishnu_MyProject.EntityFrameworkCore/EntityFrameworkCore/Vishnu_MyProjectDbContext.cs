using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Vishnu_MyProject.Authorization.Roles;
using Vishnu_MyProject.Authorization.Users;
using Vishnu_MyProject.MultiTenancy;
using Vishnu_MyProject.Contents;

namespace Vishnu_MyProject.EntityFrameworkCore
{
    public class Vishnu_MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, Vishnu_MyProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Vishnu_MyProjectDbContext(DbContextOptions<Vishnu_MyProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<CMSContent> CmsContents { get; set; }
    }
}
