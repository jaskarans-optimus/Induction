using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment26
{
    public partial class UploadXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fuXml.HasFile)
            {
                String current = Request.PhysicalApplicationPath;
                current += Server.HtmlEncode(fuXml.FileName);
                fuXml.SaveAs(current);
                try
                {
                    Utility.LoadStudentsFromXMLFile(current);
                    lblStatus.Text = "Student Records Inserted";
                }
                catch (Exception exception)
                {
                    lblStatus.Text = "Error" + exception.Message;
                }
            }
            else
            {
                lblStatus.Text = "Enter Valid Path";
            }
        }
    }
}