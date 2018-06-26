using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerRepository
{
    public class LoggedBrokerRepository
    {
        StockMarket ctx = null;
        public LoggedBrokerRepository(StockMarket dbCtx)
        {
            ctx = dbCtx;
        }
        public bool AddUser(Broker Newuser)
        {
            ctx.Broker.Add(Newuser);
            ctx.SaveChanges();
            return true;
        }
        public bool LoggedBrokers(string UserName)
        {
            bool EnterdUserName = false;
            string Loggin = (from loggin in ctx.Broker
                             where loggin.BrokerName == UserName
                             select loggin.BrokerName).FirstOrDefault();
            if (Loggin != null)
            {
                EnterdUserName = true;
            }
            return EnterdUserName;
        }
        public Broker GetBrokerassword(string UserName)
        {
            Broker Password = (from name in ctx.Broker
                                 where name.BrokerName == UserName
                                 select name).FirstOrDefault();
            return Password;
        }
        public bool GetLoggedBrokerdetail(string UserName, string Password)
        {
            Password = base64Encodepassword(Password);
            bool TrueUser = false;
            int User = (from user in ctx.Broker
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
