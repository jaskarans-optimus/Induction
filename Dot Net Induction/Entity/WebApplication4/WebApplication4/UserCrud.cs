using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public static class UserCrud
    {
       
        public static bool InsertUser(String userID ,String password,String country,String gender)
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
        public static bool Authenticate(String userID,String password)
        {
            var context = new ShipmentEntities3();
            List<UserTable> userList=context.UserTables.ToList();
            foreach (UserTable user in userList)
            {
                if (user.UserID.Equals(userID) && user.Password.Equals(password))
                    return true;
            }
            return false;
        }
        public static UserTable FindUser(String userid)
        {
            var context = new ShipmentEntities3();
          /*  List<UserTable> userList = context.UserTables.ToList();
            foreach (UserTable user in userList)
            {
                if (user.UserID.Equals(userID))
                    return user;
            }*/
            var query = from user in context.UserTables
                        where user.UserID.ToString() == userid
                        select user;
            UserTable userTable=query.First<UserTable>();

            if (userTable != null)
                return userTable;
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
            var query = from user in context.UserTables
                        where user.UserID.ToString() == userId 
                        select user;
            if (query != null)
            {
                try
                {
                    context.UserTables.Remove((UserTable)query);
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