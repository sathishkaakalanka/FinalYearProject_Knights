using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using BusinessEntity;

namespace BusinessBL
{
    public class LoggedUserBL
    {
        StockMarket ctx = new StockMarket();
        public bool CreateNewUser(string UserName, string Email, string Password)
        {
            var loggedUser = true;  
            using (StockMarket mkt = new StockMarket())
            {
                using (var ts = mkt.Database.BeginTransaction())
                {
                    if (LoggedUsers(UserName) == false)
                    {
                        loggedUser = false;
                        if (SaveUserNewUser(UserName, Email, Password) == true)
                        {
                            ts.Commit();                          
                        }
                    }             
                }
                return loggedUser;
            }
        }
        public bool LoggedUsers(string UserName)
        {
            var CheckEsistingUser = new LoggedUserRepository(ctx).LoggedUsers(UserName);
            return CheckEsistingUser;
        }
        public bool SaveUserNewUser(string UserName, string Email, string Password)
        {
            Password = base64Encodepassword(Password);
              var NewUser = new Invester();
            NewUser.InvesterId = Guid.NewGuid();
            NewUser.status = 1;
            NewUser.Email = Email;
            NewUser.InvesterName = UserName;
            NewUser.password = Password;            
            var user = new LoggedUserRepository(ctx).AddBOQ(NewUser);
            return true;
        }
        public bool GetLoggedUser(string UserName, string Password)
        {
           
            var Logged = new LoggedUserRepository(ctx).GetLoggedUserdetail(UserName, Password);
            return Logged;
        }
        public bool GetUserPassword(string UserName)
        {
            var User = new LoggedUserRepository(ctx).GetUserPassword(UserName);
           var DecordedPassword = base64DecodeUserPassword(User.password);
            var Email = User.Email;
            var SendPassword = new MessageBL().SendPassword(DecordedPassword,Email);
            return SendPassword;
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
        public static string base64DecodeUserPassword(string Password) //Decode    
        {
            try
            {
                var encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecodeByte = Convert.FromBase64String(Password);
                int charCount = utf8Decode.GetCharCount(todecodeByte, 0, todecodeByte.Length);
                char[] decodedChar = new char[charCount];
                utf8Decode.GetChars(todecodeByte, 0, todecodeByte.Length, decodedChar, 0);
                string result = new String(decodedChar);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Decode" + ex.Message);
            }
        }
    }
}

