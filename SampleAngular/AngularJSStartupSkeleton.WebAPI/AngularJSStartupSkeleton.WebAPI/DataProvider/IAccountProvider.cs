using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJS.WebAPI.Models;
using AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider;
namespace AngularJSStartupSkeleton.WebAPI.DataProvider
{
    public interface IAccountProvider 
    {
        public bool Add(Account user);
        public bool Delete(Account user);
        public bool Update(Account user);
        public Account Find(string id);
        public Account Find(string email);
    }
}
