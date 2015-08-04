using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WcfBusinessEntities
{
   [DataContract]
    [XmlSerializerFormat]
    public class Operation
    {
        private int _opId;
        [DataMember]
        public int OpId
        {
            get { return _opId; }
            set { _opId = value; }
        }
        private String _opDesc;
        [DataMember]
        public String OpDesc
        {
            get { return _opDesc; }
            set { _opDesc = value; }
        }
        private string _status;

        [DataMember]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private int _action;
        [DataMember,XmlAttribute]
        public int Action
        {
            get { return _action; }
            set { _action = value; }
        }
        private int _woNumber;
       [DataMember]
        public int WONumber
        {
            get { return _woNumber; }
            set { _woNumber = value; }
        }
       private DateTime _opCompletionDate;
       [DataMember]
       public DateTime OpCompletionDate
       {
           get { return _opCompletionDate; }
           set { _opCompletionDate = value; }
       }
       
        
        public static explicit operator WcfData.Operation(Operation operation)
        {
            WcfData.Operation operationDb = new WcfData.Operation();
            operationDb.OpId = operation.OpId;
            operationDb.OpDesc = operation.OpDesc;
            operationDb.OpStatus = operation.Status;
            if(!operation.Status.Equals("Open",StringComparison.InvariantCultureIgnoreCase))
            operationDb.OpCompletionDate = operation.OpCompletionDate;
            operationDb.WONumber = operation.WONumber;
            return operationDb;
        }
        
    }
}
