﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPpattern.Views
{
    public interface IView
    {
        string RadiusText { get; set; }
        string ResultText { get; set; }
    }
}
