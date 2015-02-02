using AngularJS.WebAPI.Interfaces;
using AngularJS.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJS.WebAPI.Controllers
{
    [RoutePrefix("api/accounts")]
    public class AccountsController : ApiController
    {
        private IAccounts IAccounts;

        public AccountsController(IAccounts _IAccounts)
        {
            IAccounts = _IAccounts;
        }

        [HttpGet]
        [Route("users")]
        public List<Users> Users()
        {
            return null;
        }

        [HttpGet]
        [Route("login")]
        public string Login(Users users)
        {
            return "value";
        }

        [HttpPost]
        [Route("signup")]
        public void SignUp([FromBody]Users value)
        {

        }

        [HttpPost]
        [Route("contact")]
        public void Contact([FromBody]Users value)
        {

        }
    }
}