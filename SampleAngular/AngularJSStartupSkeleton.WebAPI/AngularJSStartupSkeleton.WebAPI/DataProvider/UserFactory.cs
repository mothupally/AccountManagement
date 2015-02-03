using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider;

namespace AngularJSStartupSkeleton.WebAPI.DataProvider
{
    public class UserFactory
    {
        public static IUserProvider CreateUserProvider(string providerType, ConnectionManager mgr)
        {
            IUserProvider userProvider=null;
            switch (providerType)
            {
                case "Mongo":
                    userProvider = new UserProvider(mgr);
                    break;
            }
            return userProvider;
        }
    }
}