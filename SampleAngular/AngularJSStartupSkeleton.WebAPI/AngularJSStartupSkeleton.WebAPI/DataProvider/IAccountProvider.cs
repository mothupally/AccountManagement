﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJSStartupSkeleton.WebAPI.Models;
using MongoDB.Bson;
using AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider;
namespace AngularJSStartupSkeleton.WebAPI.DataProvider
{
    public interface IAccountProvider 
    {
         bool Add(Account user);
         bool Delete(Account user);
         bool Update(Account user);
         Account Find(object id);
       // public Account Find(string email);
    }
}
