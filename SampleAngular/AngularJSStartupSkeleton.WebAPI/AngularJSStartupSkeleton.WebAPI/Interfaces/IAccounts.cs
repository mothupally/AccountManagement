using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJS.WebAPI.Models;

namespace AngularJS.WebAPI.Interfaces
{
    public interface IAccounts
    {
         string Login(Users users);
         Users SignUp(Users users);
         string ForgotPassword(Users users);
         string Contact(Users users);
    }
}
