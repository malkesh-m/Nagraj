using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Nagraj.Configuration;
using Nagraj.Web;

namespace Nagraj.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NagrajDbContextFactory : IDesignTimeDbContextFactory<NagrajDbContext>
    {
        public NagrajDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NagrajDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NagrajDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NagrajConsts.ConnectionStringName));

            return new NagrajDbContext(builder.Options);
        }
    }
}
