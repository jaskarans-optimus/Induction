using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WcfData;
namespace WcfBusinessEntities
{
    [DataContract]
    [XmlSerializerFormat]
    public class WorkOrder
    {
       
        private int _woNumber;
        [DataMember]
        public int WONumber
        {
            get { return _woNumber; }
            set { _woNumber = value; }
        }
        private String _woShortText;

        [DataMember]
        public String WOShortText
        {
            get { return _woShortText; }
            set { _woShortText = value; }
        }
        private string _woLongText;

        [DataMember]
        public string WOLongText
        {
            get { return _woLongText; }
            set { _woLongText = value; }
        }
        private int _age;

        [DataMember]
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private List<Operation> _operations;
        [DataMember]
        public List<Operation> Operations
        {
            get { return _operations; }
            set { _operations = value; }
        }
        private int _action;

        [DataMember,XmlAttribute]
        public int Action
        {
            get { return _action; }
            set { _action = value; }
        }
        public static explicit operator WcfData.WorkOrder(WorkOrder workOrder)
        {
            WcfData.WorkOrder workOrderDb = new WcfData.WorkOrder();
            workOrderDb.WONumber = workOrder.WONumber;
            workOrderDb.WOShortText = workOrder.WOShortText;
            workOrderDb.WOLongText = workOrder.WOLongText;

            List<WcfData.Operation> operations = new List<WcfData.Operation>();
            foreach (Operation operation in workOrder.Operations)
            {
                operations.Add(((WcfData.Operation)operation));
            }
            workOrderDb.Operations = operations;
            return workOrderDb;
        }
    }
}
