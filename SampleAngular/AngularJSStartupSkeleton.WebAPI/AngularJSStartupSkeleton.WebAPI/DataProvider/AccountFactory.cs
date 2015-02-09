using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Mongo = AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider;
using Sql = AngularJSStartupSkeleton.WebAPI.DataProvider.SqlProvider;

namespace AngularJSStartupSkeleton.WebAPI.DataProvider
{
    public class AccountFactory
    {
        public static IAccountProvider CreateAccountProvider(string providerType)
        {
            IAccountProvider userProvider = null;
            switch (providerType.ToUpper())
            {
                case "MONGO":
                    userProvider = new Mongo.AccountProvider(ConfigurationManager.AppSettings["ConnectionManager"], ConfigurationManager.AppSettings["MongoDatabase"]);
                    break;
                case "SQL":
                    userProvider = new Sql.AccountProvider(ConfigurationManager.AppSettings["ConnectionManager"], ConfigurationManager.AppSettings["TimeOut"]);
                    break;
            }
            return userProvider;
        }
    }
}