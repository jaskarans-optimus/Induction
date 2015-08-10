using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVPpattern.Views;
using MVPpattern.Models;
namespace MVPpattern.Presenter
{

    public class CPresenter
    {
        IView _view;
        public CPresenter(IView view)
        {
            _view = view;
        }
        public String CalculateCircleArea()
        {
            ICircleModel model = new CircleModel();
            _view.ResultText=model.GetArea(double.Parse(_view.RadiusText)).ToString();
            return _view.ResultText.ToString();
        }
    }
}