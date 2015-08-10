using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCusingWinForms.Models;
using MVCusingWinForms.Views;
namespace MVCusingWinForms.Controllers
{
    public class SystemController
    {
        private SystemModel _model;
        private SystemView _view;
        public SystemController(SystemModel model, SystemView view)
        {
            _model = model;
            _view = view;
        }
        public void InitializedComponent(bool isPostBaack)
        {
            if (!isPostBaack)
                _view.InitializedView(_model);
        }
        public SystemController()
        {

        }
        public void RequestUpdate(SystemView view)
        {
            if (_model != null)
            {
                _model.UpdateModel(_view.Ram, _view.Disk, _view.CpuSpeed);
            }
        
        }    
    }
}