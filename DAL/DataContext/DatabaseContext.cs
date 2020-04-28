using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{
    public class DatabaseContext : DbContext
    {
        //class ekak hadanama database connection eka hadaganna
        public class OptionBuilder
        {
            //ctor
            public OptionBuilder()
            {
                //connection string eka ganna 
                appConfiguration=new AppConfiguration();
                optionsBuilder=new DbContextOptionsBuilder<DatabaseContext>();
                optionsBuilder.UseSqlServer(appConfiguration.sqlConnectionString);
                dbContextOptions=optionsBuilder.Options;
            }
            public DbContextOptionsBuilder<DatabaseContext> optionsBuilder{get;set;}
            //meken thamai database ekath ekka connection eka hadaganne
            public DbContextOptions<DatabaseContext> dbContextOptions { get; set; }
            // meka use karanne mona db configuration ekada karanne kiyala
            private AppConfiguration appConfiguration { get; set; }
            //meka thamai connection string eka ganne
            
        }

        
        public static OptionBuilder opbuild =new OptionBuilder();   
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base (options) { }
        public DbSet<User> usertbl { get; set; }
        public DbSet<AuthenticationLevel> Authtbl { get; set; }

        
        
    }
}