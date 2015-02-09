using AngularJSStartupSkeleton.WebAPI.Models;
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
        private IAccountProvider userProvider;

        public AccountsController()
        {
            userProvider = AccountFactory.CreateAccountProvider(ConfigurationManager.AppSettings["providerType"]);
        }

        [HttpGet]
        [Route("user/{requestGuid}")]
        public IHttpActionResult GetUserDetails(Guid requestGuid)
        {
            AccountDetails accountDetails = userProvider.GetUserDetails(requestGuid);
            return Ok(accountDetails);
        }

        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login([FromBody]Account user)
        {
            AccountDetails account = userProvider.UserLogin(user);
            return Ok(account);
        }

        [HttpPost]
        [Route("signup")]
        public void SignUp([FromBody]Account user)
        {
            bool isSuccess = userProvider.Add(user);
        }

        [HttpPost]
        [Route("settings")]
        public void Settings([FromBody]AccountDetails value)
        {
            bool isSuccess = userProvider.UpdateUserDetails(value);
        }

        [HttpPost]
        [Route("contact")]
        public void Contact([FromBody]AccountContacts value)
        {
            bool isSuccess = userProvider.AddContact(value);
        }
    }
}