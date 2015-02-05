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
using System.Configuration;

namespace AngularJSStartupSkeleton.WebAPI.DataProvider.SqlProvider
{
    public static class ConnectionManager
    {
        public static SqlConnection CreateSqlConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }

        public static SqlCommand CreateSqlCommand(string timeOut)
        {
            SqlCommand command = new SqlCommand
            {
                CommandTimeout = Convert.ToInt32(timeOut)
            };
            return command;
        }

    }
}
