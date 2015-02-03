using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJS.WebAPI.Models;
using AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider;
namespace AngularJSStartupSkeleton.WebAPI.DataProvider
{
    public interface IUserProvider 
    {
        public bool Add(User user);
        public bool Delete(User user);
        public bool Update(User user);
        public User Find(string id);
        public User Find(string email);
    }
}
