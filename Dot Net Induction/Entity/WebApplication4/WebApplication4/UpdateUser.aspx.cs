using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            Status.Text = "";
        }
        protected void GetDetails_Click(object sender, EventArgs e)
        {
            UserTable user=UserCrud.FindUser(UserID.Text);
            if (user != null)
            {
                Pass.Text = user.Password;
                Country.Text = user.Country;
                Gender.Text = user.Gender;
            }
            else
            {
                Status.Text = "UserID Incorrect";
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            UserTable user = new UserTable();
            user.UserID = Int32.Parse(UserID.Text);
            user.Password = Pass.Text;
            user.Country = Country.Text;
            user.Gender = Gender.Text;
            Status.Text = "User Updated";
        }
    }
}