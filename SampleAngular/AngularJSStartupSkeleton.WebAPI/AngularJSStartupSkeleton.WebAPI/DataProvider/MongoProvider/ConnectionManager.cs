using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System.Data.SqlClient;

namespace AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider
{
    public static class ConnectionManager
    {

        public static MongoClient _client;
        public static MongoServer _server;
        public static string _database;
        public static string _providerType;
        public static object obj = new object();


        public static MongoDatabase MongoDb(string connectionString,string database) 
        {
            if (_client == null)
            {
                lock (obj)
                {
                    if (_client == null)
                    {
                        _client = new MongoClient(connectionString);
                    }
                }
            }

            return _client.GetServer().GetDatabase(database);
        }
    }
}
