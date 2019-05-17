using Entity.DataModel;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.IO;

namespace DAL
{
    public class Context
    {
        private static Context instence = null;

        public static Context Instance
        {
            get
            {
                return instence ?? new Context();
            }
        }

        public readonly IMongoDatabase database;
        private Context()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);

            var root = config.Build();
            var connectionStrings = root.GetSection("ConnectionStrings");
            var mongoString = connectionStrings["MongoConn"];
            database = new MongoClient(mongoString).GetDatabase("EduProfile");

        }
    }
}
