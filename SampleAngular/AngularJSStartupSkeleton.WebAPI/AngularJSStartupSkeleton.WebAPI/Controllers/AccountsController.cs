using AngularJS.WebAPI.Interfaces;
using AngularJS.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSStartupSkeleton.WebAPI.DataProvider;
using AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider;
using System.Configuration;

namespace AngularJS.WebAPI.Controllers
{
    [RoutePrefix("api/accounts")]
    public class AccountsController : ApiController
    {
        private IAccount IAccounts;
        private IAccountProvider userProvider;
        private ConnectionManager manager;
        public AccountsController()
        {
            
            //manager = new ConnectionManager(ConfigurationManager.AppSettings["ConnectionManager"]);
            userProvider = AccountFactory.CreateUserProvider(ConfigurationManager.AppSettings["providerType"],manager);
        }

        [HttpGet]
        [Route("User")]
        public List<Account> User()
        {
            return null;
        }

        [HttpGet]
        [Route("login")]
        public string Login(Account User)
        {
            return "value";
        }

        [HttpPost]
        [Route("signup")]
        public void SignUp([FromBody]Account user)
        {
            bool isSuccess = userProvider.Add(user);
        }

        [HttpPost]
        [Route("contact")]
        public void Contact([FromBody]Account value)
        {

        }
    }
}