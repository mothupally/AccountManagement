﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using AngularJS.WebAPI.Models;
namespace AngularJSStartupSkeleton.WebAPI.DataProvider.MongoProvider
{
    public class AccountProvider : IAccountProvider
    {

        
        public MongoCollection<Account> userCollection;

        public AccountProvider(string connectionString,string database)
        {

            userCollection = ConnectionManager.MongoDb(connectionString,database).GetCollection<Account>("User");
        }
        public bool Add(Account user)
        {
            userCollection.Insert<Account>(user);
            return true;
        }

        public bool Delete(Account user)
        {
            var query = Query<Account>.EQ(e => e.Id, user.Id);
            userCollection.Remove(query);
            return true;
        }

        public bool Update(Account user)
        {
            userCollection.Save(user);
            return true;
        }

        public Account Find(string id)
        {
            var query = Query<Account>.EQ(e => e.Id, id);
            var entity = userCollection.FindOne(query);
            return entity;
        }

        public Account Find(string email)
        {
            var query = Query<Account>.EQ(e => e.EmailAddress, email);
            var entity = userCollection.FindOne(query);
            return entity;
        }
    }
}