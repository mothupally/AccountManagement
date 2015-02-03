using System;
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
    public class UserProvider : IUserProvider
    {

        public ConnectionManager manager;
        public MongoCollection<User> userCollection;

        public UserProvider(ConnectionManager conn)
        {
            manager = conn;
            userCollection = manager.Db.GetCollection<User>("User");
        }
        public bool Add(User user)
        {
            userCollection.Insert<User>(user);
            return true;
        }

        public bool Delete(User user)
        {
            var query = Query<User>.EQ(e => e.Id, user.Id);
            userCollection.Remove(query);
            return true;
        }

        public bool Update(User user)
        {
            userCollection.Save(user);
            return true;
        }

        public User Find(string id)
        {
            var query = Query<User>.EQ(e => e.Id, id);
            var entity = userCollection.FindOne(query);
            return entity;
        }

        public User Find(string email)
        {
            var query = Query<User>.EQ(e => e.EmailAddress, email);
            var entity = userCollection.FindOne(query);
            return entity;
        }
    }
}