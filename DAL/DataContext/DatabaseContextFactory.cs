using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{
    public class DatabaseContextFactory :IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext  CreateDbContext(string[] args)
        {
            AppConfiguration appConfiguration =new AppConfiguration();
            var OpsBuilder=new DbContextOptionsBuilder<DatabaseContext>();
            OpsBuilder.UseSqlServer(appConfiguration.sqlConnectionString);
            return new DatabaseContext(OpsBuilder.Options);
        
        }   
    }
}