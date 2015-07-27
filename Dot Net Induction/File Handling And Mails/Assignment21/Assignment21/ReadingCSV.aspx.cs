using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment21
{
    public partial class ReadingCSV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Save File on Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SaveStudentToDB(object sender, EventArgs e)
        {
            String savePath = Request.PhysicalApplicationPath;
            if (UploadStudentCSV.HasFile)
            {
                String fileName = UploadStudentCSV.FileName;
                savePath += Server.HtmlEncode(fileName);
                UploadStudentCSV.SaveAs(savePath);
                if (Utility.LoadFromCSV(savePath))
                {
                    lblDatabaseStatus.Text = "Your Records Stored in Database";
                }
                else
                {
                    lblDatabaseStatus.Text = "Your Records Failed to Store";
                }
                lblUploadStatus.Text = "Your file save as " + fileName;
            }
            else
            {
                lblUploadStatus.Text = "You did not specify a file to upload";
            }
        }
    }
}