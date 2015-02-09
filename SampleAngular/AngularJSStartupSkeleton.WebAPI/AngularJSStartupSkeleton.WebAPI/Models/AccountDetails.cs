using System;
using MongoDB.Bson;
namespace AngularJSStartupSkeleton.WebAPI.Models
{
    public class AccountDetails
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int? Phone { get; set; }
        public int? zip { get; set; }
    }
}
