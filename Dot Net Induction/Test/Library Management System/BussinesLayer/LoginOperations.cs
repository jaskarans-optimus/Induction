using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public static class LoginOperations
    {
        public static bool AdminAuthentication(String userName, String password)
        {
            return DataLayer.LoginDbOperations.AdminAuthentication(userName, password);
        }
        public static bool StudentAuthentication(String userName, String password)
        {
            return DataLayer.LoginDbOperations.StudentAuthentication(userName, password);
        }
    }
}
