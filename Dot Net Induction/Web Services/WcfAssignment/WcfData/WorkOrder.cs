//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfData
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            this.Operations = new HashSet<Operation>();
        }
    
        public int WONumber { get; set; }
        public string WOShortText { get; set; }
        public string WOLongText { get; set; }
    
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
