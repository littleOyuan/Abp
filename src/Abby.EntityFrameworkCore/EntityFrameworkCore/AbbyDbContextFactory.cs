using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Abby.Configuration;
using Abby.Web;

namespace Abby.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbbyDbContextFactory : IDesignTimeDbContextFactory<AbbyDbContext>
    {
        public AbbyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbbyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbbyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbbyConsts.ConnectionStringName));

            return new AbbyDbContext(builder.Options);
        }
    }
}
