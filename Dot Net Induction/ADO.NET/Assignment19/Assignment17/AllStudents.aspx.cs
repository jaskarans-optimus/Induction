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
                Dictionary<int, string> streams;
                if (Cache["Streams"] != null)
                {
                    streams = (Dictionary<int, string>)Cache["Streams"];
                }
                else
                {
                    streams = UtilityFunctions.GetAllStreams();
                    Cache["Streams"] = streams;
                }
                foreach (var pair in streams)
                {
                    StreamList.Items.Add(new ListItem(pair.Value, pair.Key.ToString()));
                }
            }
        }

        protected void StreamList_SelectedIndexChanged(object sender, EventArgs e)
        {
        BindData();
            
        }
        private DataTable BindData()
        {
            int streamID = StreamList.SelectedIndex + 1;
            String queryString = String.Format("SELECT * FROM Student WHERE Streams={0}", streamID);
            DataTable dataTable = UtilityFunctions.GetData(queryString);
            if (dataTable.Rows.Count > 0)
            {
                StudentGrid.DataSource = dataTable;
                StudentGrid.DataBind();
            }
            else
            {
                Status.Text = "Unable to connect Database";
            }
            return dataTable;
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            StudentGrid.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void StudentGrid_Sorting(object sender, GridViewSortEventArgs e)
        {

            DataView view = new DataView(BindData());
            view.Sort = e.SortExpression + " " + "Asc";
            StudentGrid.DataSource = view;
            StudentGrid.DataBind();

        }
    }
}