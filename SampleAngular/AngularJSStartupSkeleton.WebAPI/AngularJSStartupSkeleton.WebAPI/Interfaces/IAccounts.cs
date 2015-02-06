using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJSStartupSkeleton.WebAPI.Models;

namespace AngularJSStartupSkeleton.WebAPI.Interfaces
{
    public interface IAccount
    {
         string Login(Account users);
         Account SignUp(Account users);
         string ForgotPassword(Account users);
         string Contact(Account users);
    }
}
