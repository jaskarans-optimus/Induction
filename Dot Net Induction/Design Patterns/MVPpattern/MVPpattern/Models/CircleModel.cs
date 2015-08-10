using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPpattern.Models
{
    /// <summary>
    /// Model Class
    /// </summary>
    public class CircleModel:ICircleModel
    {
        public CircleModel()
        {

        }
        double ICircleModel.GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}