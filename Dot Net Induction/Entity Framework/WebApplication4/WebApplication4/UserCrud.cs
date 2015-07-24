using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public static class UserCrud
    {

        public static bool InsertUser(String userID, String password, String country, String gender)
        {
            try
            {
                var context = new ShipmentEntities3();
                UserTable user1 = new UserTable();
                user1.UserID = Int32.Parse(userID);
                user1.Password = password;
                user1.Country = country;
                user1.Gender = gender;
                context.UserTables.Add(user1);
                context.SaveChanges();
                context.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool Authenticate(String userID, String password)
        {
            int userId = 0;
            int.TryParse(userID, out userId);
            var context = new ShipmentEntities3();
            UserTable user = (from u in context.UserTables
                              where u.UserID == userId && u.Password == password
                              select u).FirstOrDefault();
            //foreach (UserTable user in userList)
            //{
            //    if (user.UserID.Equals(userId) && user.Password.Equals(password))
            //        return true;
            //}
            if (user != null)
            {
                return true;
            }
            return false;
        }
        public static UserTable FindUser(int userid)
        {
            var context = new ShipmentEntities3();
            /*  List<UserTable> userList = context.UserTables.ToList();
              foreach (UserTable user in userList)
              {
                  if (user.UserID.Equals(userID))
                      return user;
              }*/
            var query =(from user in context.UserTables
                        where userid==user.UserID
                        select user);
           
            foreach (UserTable user in query)
            {
                if (user!= null)
                    return user;
            } 
            return null;
        }
        public static bool UpdateUser(UserTable userTable)
        {

            var context = new ShipmentEntities3();
            var query = from user in context.UserTables
                        where user.UserID == userTable.UserID
                        select user;
            foreach (UserTable user in query)
            {
                user.Password = userTable.Password;
                user.Country = userTable.Country;
                user.Gender = userTable.Gender;
            }
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool DeleteUser(String userId)
        {
            var context = new ShipmentEntities3();
            int userid1 = Convert.ToInt32(userId);
            var query = from user in context.UserTables
                        where user.UserID == userid1
                        select user;
            if (query != null)
            {
                try
                {
                    foreach (UserTable user in query)
                    {
                        context.UserTables.Remove(user);
                    }
                        context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return false;
        }


    }
}