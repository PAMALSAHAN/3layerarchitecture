using Microsoft.Extensions.Configuration;
using System.IO;

namespace DAL.DataContext
{
    public class AppConfiguration
    {
        //ctor ekak hadanawa
        public AppConfiguration()
        {
            //configuration builder ekak use karanawa configuration eka hadaganna
            var configBuilder=new ConfigurationBuilder();
            // path ekata gihin appsetting eka hadaganna eka
            var path=Path.Combine(Directory.GetCurrentDirectory(),"appsettings.json");
            //path ekata gihin json file eka add karaganna eka
            configBuilder.AddJsonFile(path,false);
            //build karaganna eka
            var root=configBuilder.Build();
            //section ekak ganna eka connection string eke
            var appsetting=root.GetSection("ConnectionStrings:connection");
            // eka prperty ekata add karaganna widiha
            sqlConnectionString=appsetting.Value;
        }
        public string sqlConnectionString { get; set; }
    }
}