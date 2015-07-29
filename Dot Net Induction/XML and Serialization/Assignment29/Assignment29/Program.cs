using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Assignment29
{
    class Program
    {
        static void Main(string[] args)
        {
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load("C:\\Users\\optimus150.OPTIMUSDOM\\documents\\visual studio 2012\\Projects\\Assignment29\\Assignment29\\FirstStyleSheet.xsl");
            XPathDocument myXPathDoc = new XPathDocument("C:\\Users\\optimus150.OPTIMUSDOM\\documents\\visual studio 2012\\Projects\\Assignment29\\Assignment29\\Students.xml");
            XmlTextWriter myWriter = new XmlTextWriter("result.html",null);
            myXslTrans.Transform(myXPathDoc,null,myWriter);
            System.Diagnostics.Process.Start("result.html");
            Console.ReadKey();
        }
    }
}
