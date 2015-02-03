using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJS.WebAPI.Models;
namespace AngularJSStartupSkeleton.WebAPI.DataProvider
{
    public interface IUserProvider
    {
        public bool Add(User user);
        public bool Delete(User user);
        public bool Find(User user);
    }
}
