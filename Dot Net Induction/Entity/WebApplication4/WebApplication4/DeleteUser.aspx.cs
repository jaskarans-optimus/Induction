using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            Status.Text = "";
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            if (UserCrud.DeleteUser(UserID.Text))
            {
                Status.Text = "User Deleted";
            }
            else
                Status.Text = "User Not Deleted";
        }
    }

}