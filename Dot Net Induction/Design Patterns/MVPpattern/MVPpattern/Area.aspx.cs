using MVPpattern.Presenter;
using MVPpattern.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVPpattern
{
    public partial class Area : System.Web.UI.Page,IView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void ButtonResult_Click(object sender, EventArgs e)
        {
            CPresenter presenter = new CPresenter(this);
            presenter.CalculateCircleArea();
        }
        public string RadiusText
        {
            get { return txtRadius.Text; }
            set { txtRadius.Text = value; }
        }
        public string ResultText
        {
            get { return lblResult.Text; }
            set { lblResult.Text = value; }
        }
    }
}