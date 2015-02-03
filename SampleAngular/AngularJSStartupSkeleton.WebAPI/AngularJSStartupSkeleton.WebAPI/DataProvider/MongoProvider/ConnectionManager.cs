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

namespace AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider
{
    public class ConnectionManager<T>
    {
        T client;
        public string connectionString;
        public static MongoClient _client;
        public static MongoServer _server;
        public static string _database;
        public static string _providerType;
        public static object obj;

        public ConnectionManager(string _connectionString,string providerType)
        {
            connectionString = _connectionString;
            _providerType = providerType;
        }

        public T GetClient()
        {
            switch (_providerType)
            {
                case "Mongo":
                    Type type = Type.GetType("MongoClient", true);
                    object Instance = Activator.CreateInstance(type);
                    client = Instance;
                    return client;
                    break;
            }
            return default(T);
        }

        public MongoClient MongoClient{ 
            get{
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
            
                return _client;
            } 
        }

        public MongoServer Server
        {
            get{
                return MongoClient.GetServer();
            }
        }

        public MongoDatabase Db
        {
            get
            {
                return Server.GetDatabase(_database);
            }
        }
    }
}
