using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVCusingWinForms.Controllers;
using MVCusingWinForms.Models;
namespace MVCusingWinForms.Views
{
    public partial class SystemView : System.Web.UI.UserControl
    {
        private SystemController _control;
        private SystemModel _model = new SystemModel("Windows xp", 2, 10, 2);
        protected void Page_Load(object sender, EventArgs e)
        {
            _control = new SystemController(_model, this);
            _model.AddObserver(this);
            _control.InitializedComponent(IsPostBack);
        }
        public float Ram { get; set; }
        public float Disk { get; set; }
        public float CpuSpeed { get; set; }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            float temp;
            if (float.TryParse(txtProcessor.Text, out temp))
                CpuSpeed = temp;
            if (float.TryParse(txtRam.Text, out temp))
                Ram = temp;
            if (float.TryParse(txtDisk.Text, out temp))
                CpuSpeed = temp;
            _control.RequestUpdate(this);
        }
        public void Update(SystemModel model)
        {
            UpdateInterface(model);
        }

        public void UpdateInterface(SystemModel model)
        {
            if (Ram != model.Ram)
                lblRam.Text = model.Ram.ToString("N");
            if (Disk != model.Disk)
                lblDisk.Text = model.Disk.ToString("N");
            if(CpuSpeed!=model.CpuSpeed)
                lblcpuspeed.Text=model.CpuSpeed.ToString("N");
        }
        public void InitializedView(SystemModel model)
        {
            lblRam.Text = model.Ram.ToString("N");
            lblDisk.Text = model.Disk.ToString("N");
            lblcpuspeed.Text = model.CpuSpeed.ToString("N");
        }
    }
}