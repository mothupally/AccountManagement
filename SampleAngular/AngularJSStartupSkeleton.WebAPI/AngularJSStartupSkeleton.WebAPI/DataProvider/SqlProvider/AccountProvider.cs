using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJS.WebAPI.Models;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace AngularJSStartupSkeleton.WebAPI.DataProvider.SqlProvider
{
    public class AccountProvider : IAccountProvider
    {
        public string connectionString;
        public string timeOut;
        public AccountProvider(string _connectionString,string timeout)
        {
            connectionString = _connectionString;
            timeOut = timeout;
        }
        public bool Add(Account user)
        {
            using (SqlConnection connection = ConnectionManager.CreateSqlConnection(connectionString)
                    )
            {
                using (SqlCommand oCommand = new SqlCommand())
                {
                    connection.Open();
                    oCommand.CommandText = "StoredProcName";
                    oCommand.Connection = connection;
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.CommandTimeout = Convert.ToInt32(timeOut);
                    SqlDataAdapter adapter = new SqlDataAdapter(oCommand);
                }
            }
            return true;
        }

        public bool Delete(Account user)
        {
            
            return true;
        }

        public bool Update(Account user)
        {
            return true;
        }

        public Account Find(string id)
        {
            return null;
        }

        public Account Find(string email)
        {
            return null;
        }
    }
}