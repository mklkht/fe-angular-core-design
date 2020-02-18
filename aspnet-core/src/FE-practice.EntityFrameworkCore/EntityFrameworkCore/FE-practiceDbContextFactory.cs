using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FE-practice.Configuration;
using FE-practice.Web;

namespace FE-practice.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FE-practiceDbContextFactory : IDesignTimeDbContextFactory<FE-practiceDbContext>
    {
        public FE-practiceDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FE-practiceDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FE-practiceDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FE-practiceConsts.ConnectionStringName));

            return new FE-practiceDbContext(builder.Options);
        }
    }
}
