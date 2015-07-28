using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Net.Mail;
using System.Net;
namespace Assignment23
{
    public partial class UploadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            StringBuilder fileDeleted = new StringBuilder();
            if (txtPath.Text.CompareTo("")==0)
            {
                lblStatus.Text = "Enter Path";
            }
            else
            {
            
                DirectoryInfo directory = new DirectoryInfo(txtPath.Text);
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.Length > 100)
                    {
                        try
                        {
                            fileDeleted.AppendLine(file.Name+"\n");
                            File.Delete(file.FullName);
                          
                        }
                        catch (Exception exception)
                        {
                            lblStatus.Text = "Error: " + exception.Message;
                        }
                        MailMessage mail = new MailMessage();
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("jaskaran.singh@optimusinfo.com");
                        mail.To.Add(new MailAddress("jaskaransr93@gmail.com"));
                        mail.Subject = "Deleted Files";
                        mail.Body = fileDeleted.ToString();
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new NetworkCredential("jaskaran.singh@optimusinfo.com", "");
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mail);
                        lblStatus.Text = "Mail Send";

                    }
                    else
                    {
                        using (StreamWriter writer = file.AppendText())
                        {
                            writer.WriteLine("Size less than 100 bytes");
                        }
                    }
                }
            }
        }
    }
}