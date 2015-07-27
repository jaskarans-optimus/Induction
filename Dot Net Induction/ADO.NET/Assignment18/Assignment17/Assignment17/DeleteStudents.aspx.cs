using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment17
{
    public partial class DeleteStudents : System.Web.UI.Page
    {
        string leftSelected;
        string rightSelected;
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                Dictionary<int, string> streams = UtilityFunctions.GetAllStreams();

                foreach (var pair in streams)
                {
                    Streams.Items.Add(new ListItem(pair.Value, pair.Key.ToString()));
                }
                Streams_SelectedIndexChanged(sender, e);
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string selected = "";
            foreach (ListItem item in RightList.Items)
            {
                if (item.Selected)
                {
                    selected += item.Value + ",";
                }
            }
            foreach (ListItem item in LeftList.Items)
            {
                 if (item.Selected)
                {
                    selected += item.Value + ",";
                    
                }
            }
            
            try
            {
                UtilityFunctions.DeleteStudents(selected);
                Status.Text = "Student Deleted";
                Streams_SelectedIndexChanged(sender, e);
                
            }
            catch (Exception exception)
            {
                Status.Text = "Error:Student Delete operation failed";
            }

        }

        protected void Left_Click(object sender, EventArgs e)
        {

            List<ListItem> selected = new List<ListItem>();
            foreach (ListItem item in RightList.Items)
            {
                if (item.Selected)
                {
                    selected.Add(item);
                }
            }
            foreach (ListItem item in selected)
            {
                RightList.Items.Remove(item);
                LeftList.Items.Add(item);
            }
           

        }

        protected void Right_Click(object sender, EventArgs e)
        {
           
            List<ListItem> selected = new List<ListItem>();
            foreach (ListItem item in LeftList.Items)
            {
                if (item.Selected)
                {
                    selected.Add(item);                 
                }
            }
            foreach (ListItem item in selected)
            {
                LeftList.Items.Remove(item);
                RightList.Items.Add(item);
            }
           

        }

        protected void Streams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              
                LeftList.Items.Clear();
                int streamID = Streams.SelectedIndex + 1;
                String query = String.Format("Select Name,id FROM Student WHERE Streams={0}", streamID);
                DataTable studentTable = UtilityFunctions.GetData(query);
                if (studentTable.Rows.Count > 0)
                {
                    for (int i=0;i<studentTable.Rows.Count;i++)
                    {
                        LeftList.Items.Add(new ListItem(studentTable.Rows[i]["Name"].ToString(),studentTable.Rows[i]["id"].ToString()));
                    }
                }
            }
            catch (Exception exception)
            {
                Status.Text = "Error:" + exception.Message;
            }
        }


    }
}