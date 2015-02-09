using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJSStartupSkeleton.WebAPI.Models;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using AngularJSStartupSkeleton.WebAPI.SQLDBContext;
namespace AngularJSStartupSkeleton.WebAPI.DataProvider.SqlProvider
{
    public class AccountProvider : IAccountProvider
    {
        public AccountProvider(string connectionString, string database)
        {
        }
        public AccountDetails GetUserDetails(Guid id)
        {
            AccountDetails accountDetails = new AccountDetails();
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                var result = dbContext.User_Details.Where(x => x.User_Id == id).FirstOrDefault();
                if (result != null)
                {
                    accountDetails.Id = result.Id;
                    accountDetails.UserId = result.User_Id;
                    accountDetails.FirstName = result.FirstName;
                    accountDetails.LastName = result.LastName;
                    accountDetails.MiddleName = result.MiddleName;
                    accountDetails.CompanyName = result.companyName;
                    accountDetails.Phone = result.Phone;
                    accountDetails.zip = result.Zip;

                }
            }
            return accountDetails;
        }

        public bool Add(Account user)
        {
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                User_Account userAccount = new User_Account();

                var queryResult = dbContext.User_Account.Where(x => x.EmailAddress == user.EmailAddress && x.Password == user.Password).FirstOrDefault();
                if (queryResult == null)
                {
                    userAccount.Id = Guid.NewGuid();
                    userAccount.UserName = user.UserName;
                    userAccount.EmailAddress = user.EmailAddress;
                    userAccount.Password = user.Password;
                    dbContext.User_Account.Add(userAccount);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool Delete(Account user)
        {
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                var userAccount = dbContext.User_Account.Where(x => x.Id == (Guid)user.Id).FirstOrDefault();
                dbContext.User_Account.Remove(userAccount);
                dbContext.SaveChanges();
            }
            return true;
        }

        public bool Update(Account user)
        {
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                var userAccount = dbContext.User_Account.Where(x => x.Id == (Guid)user.Id).FirstOrDefault();
                userAccount.Id = (Guid)user.Id;
                userAccount.UserName = user.UserName;
                userAccount.EmailAddress = user.EmailAddress;
                userAccount.Password = user.Password;
                dbContext.User_Account.Remove(userAccount);
                dbContext.SaveChanges();
            }
            return true;
        }

        public Account Find(object id)
        {
            Account account = new Account();
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                var userAccount = dbContext.User_Account.Where(x => x.Id == (Guid)id).FirstOrDefault();
                userAccount.Id = (Guid)userAccount.Id;
                account.UserName = userAccount.UserName;
                account.Password = userAccount.Password;
                account.EmailAddress = userAccount.EmailAddress;
            }
            return account;
        }

        public bool AddContact(AccountContacts accountContacts)
        {
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                User_Contacts userContact = new User_Contacts();
                var queryResult = dbContext.User_Contacts.Where(x => x.Id == accountContacts.Id).FirstOrDefault();
                if (queryResult == null)
                {
                    userContact.Id = Guid.NewGuid();
                    userContact.UserName = accountContacts.UserName;
                    userContact.EmailAddress = accountContacts.EmailAddress;
                    userContact.Message = accountContacts.Message;
                    dbContext.User_Contacts.Add(userContact);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool UpdateUserDetails(AccountDetails userDetails)
        {
            Account account = new Account();
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                User_Details user_Details = new User_Details();
                var userAccount = dbContext.User_Account.Where(x => x.Id == userDetails.UserId).FirstOrDefault();
                if (userAccount != null)
                {
                    if (userAccount.User_Details.Count() <= 0)
                    {
                        user_Details.Id = Guid.NewGuid();
                        user_Details.User_Id = (Guid)userDetails.UserId;
                        user_Details.FirstName = userDetails.FirstName;
                        user_Details.LastName = userDetails.LastName;
                        user_Details.MiddleName = userDetails.MiddleName;
                        user_Details.companyName = userDetails.CompanyName;
                        user_Details.Phone = userDetails.Phone;
                        user_Details.Zip = userDetails.zip;
                        dbContext.User_Details.Add(user_Details);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        var userDetail = dbContext.User_Details.Where(x => x.User_Id == userAccount.Id).FirstOrDefault();
                        userDetail.FirstName = userDetails.FirstName;
                        userDetail.LastName = userDetails.LastName;
                        userDetail.MiddleName = userDetails.MiddleName;
                        userDetail.companyName = userDetails.CompanyName;
                        userDetail.Phone = userDetails.Phone;
                        userDetail.Zip = userDetails.zip;
                        dbContext.SaveChanges();
                        return true;
                    }
                }
            }
            return false;
        }

        public AccountDetails UserLogin(Account account)
        {
            AccountDetails accountDetails = new AccountDetails();
            using (AccountMgtDBEntities dbContext = new AccountMgtDBEntities())
            {
                var userAccount = dbContext.User_Account.Where(x => x.EmailAddress == account.EmailAddress && x.Password == account.Password).FirstOrDefault();
                if (userAccount != null)
                {
                    accountDetails.UserId = userAccount.Id;
                    return accountDetails;
                }
            }
            return null;
        }
    }
}