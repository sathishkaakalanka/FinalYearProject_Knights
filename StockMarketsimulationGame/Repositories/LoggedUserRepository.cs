using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BusinessEntity;

namespace Repositories
{
    public class LoggedUserRepository:StockMarket
    {
        StockMarket ctx = null;
        public LoggedUserRepository(StockMarket dbCtx)
        {
            ctx = dbCtx;
        }
        public bool AddUser(Invester Newuser)
        {
            ctx.Invester.Add(Newuser);
            ctx.SaveChanges();
            return true;
        }
        public bool LoggedUsers(string UserName)
        {
            bool EnterdUserName = false;
            string Loggin = (from loggin in ctx.Invester
                             where loggin.InvesterName == UserName
                             select loggin.InvesterName).FirstOrDefault();
            if (Loggin != null)
            {
                EnterdUserName = true;
            }
            return EnterdUserName;
        }
        public Invester GetUserPassword(string UserName)
        {
            Invester Password = (from name in ctx.Invester
                            where name.InvesterName == UserName
                            select name).FirstOrDefault();
            return Password;
        }
        public bool  GetLoggedUserdetail(string UserName, string Password)
        {
            Password = base64Encodepassword(Password);
            bool TrueUser = false;
            int User = (from user in ctx.Invester
                                  // where user.InvesterName == UserName /*&& user.password == Password*/
                                   select user).ToList().Count;
            if (User != 0)
            {
                TrueUser = true;
            }
            return TrueUser;
        }
        public static string base64Encodepassword(string password) // Encode    
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
    }
}
