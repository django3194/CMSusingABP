using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Vishnu_MyProject.Configuration;
using Vishnu_MyProject.Web;

namespace Vishnu_MyProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Vishnu_MyProjectDbContextFactory : IDesignTimeDbContextFactory<Vishnu_MyProjectDbContext>
    {
        public Vishnu_MyProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Vishnu_MyProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Vishnu_MyProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Vishnu_MyProjectConsts.ConnectionStringName));

            return new Vishnu_MyProjectDbContext(builder.Options);
        }
    }
}
