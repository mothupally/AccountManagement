using System;
using MongoDB.Bson;
namespace AngularJSStartupSkeleton.WebAPI.Models
{
    public class AccountContacts
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
    }
}
