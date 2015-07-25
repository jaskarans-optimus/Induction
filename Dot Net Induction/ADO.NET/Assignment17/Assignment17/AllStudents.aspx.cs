using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Assignment17
{
    public partial class AllStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<int,string> streams=UtilityFunctions.GetAllStreams();

                foreach (var pair in streams)
                {
                    StreamList.Items.Add(new ListItem(pair.Value, pair.Key.ToString()));
                }
            }
        }

        protected void StreamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int streamID=StreamList.SelectedIndex+1;
            String queryString = String.Format("SELECT * FROM Student WHERE Streams={0}", streamID);
            DataSet dataSet = UtilityFunctions.GetData(queryString);
            if (dataSet.Tables.Count > 0)
            {
                StudentGrid.DataSource = dataSet;
                StudentGrid.DataBind();
            }
            else
            {
                Status.Text = "Unable to connect Database";
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            StudentGrid.PageIndex = e.NewPageIndex;
            StudentGrid.DataBind();
        }
    }
}