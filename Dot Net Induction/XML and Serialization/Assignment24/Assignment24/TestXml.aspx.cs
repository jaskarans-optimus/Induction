using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;
using System.Xml;
using System.Text;
namespace Assignment24
{
    public partial class TestXml : System.Web.UI.Page
    {
        private static string fileName = "XmlDoc.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateXmlDocument();
            }

        }
        private void CreateXmlDocument()
        {
            //lblStatus.Text = System.IO.Directory.GetCurrentDirectory();
            using (XmlTextWriter writer = new XmlTextWriter("XmlDoc.xml", System.Text.Encoding.UTF8))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("iCalibrator");
                writer.WriteWhitespace("\n");
                writer.WriteStartElement("Training");
                writer.WriteAttributeString("day", "1");
                writer.WriteElementString("Chapter", "XML-1");
                writer.WriteElementString("Chapter", "XML-2");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();

            }

        }
        protected void AddNode_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XmlNode root = document.DocumentElement;
            XmlElement element = document.CreateElement("Assignment");
            element.SetAttribute("Submitted", "y");
            XmlElement number = document.CreateElement("number");
            number.InnerText = "1";
            element.AppendChild(number);
            root.AppendChild(element);
            document.Save(fileName);
            lblStatus.Text = "Assignment Node added";
        }

        protected void btnInsertNode_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XmlElement root = document.DocumentElement;
            XmlNodeList nodes = root.ChildNodes;
            XmlElement element = document.CreateElement("Testing");
            foreach (XmlNode node in nodes)
            {
                if (node.Name.CompareTo("Training") == 0)
                {
                    root.InsertBefore(element, node);
                }
            }
            document.Save(fileName);
            lblStatus.Text = "Testing node Added";
        }

        protected void btnRemoveNode_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XmlElement root = document.DocumentElement;
            XmlNodeList nodes = root.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                if (node.Name.CompareTo("Assignment") == 0)
                {
                    root.RemoveChild(node);
                }
            }
            document.Save(fileName);
            lblStatus.Text = "Assignment Node removed";
        }

        protected void btnChildNodes_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XPathNavigator navigator = document.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();
            StringBuilder childNodes = new StringBuilder();
            if (navigator.HasChildren)
            {
                navigator.MoveToFirstChild();
                do
                {
                    childNodes.Append(navigator.Name + "--");
                } while (navigator.MoveToNext());
            }
            txtChildNodes.Text = childNodes.ToString();
        }

        protected void btnTotalNodes_Click(object sender, EventArgs e)
        {
                     XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XPathNavigator navigator = document.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();
            StringBuilder childNodes = new StringBuilder();
            int count=0;
            if (navigator.HasChildren)
            {
                navigator.MoveToFirstChild();
                do
                {
                    count++;
                } while (navigator.MoveToNext());
            }
            lblTotalNodes.Text=Convert.ToString(count);
        }

        protected void btnReplaceChild_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XPathNavigator navigator = document.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();
            if (navigator.HasChildren)
            {
                navigator.MoveToFirstChild();
                do
                {
                    if (navigator.Name.CompareTo("Testing") == 0)
                    {
                        navigator.ReplaceSelf("<Testing_Over />");
                    }
                } while (navigator.MoveToNext());
            }
            document.Save(fileName);
            lblStatus.Text = "Testing replaced by Testing Over";
        }
       
        


    }
}