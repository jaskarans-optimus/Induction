using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfBusinessEntities;
namespace WcfAssignment
{
   
    public class Service1 : IService1
    {

        void IService1.SendWorkOrderData(IList<WorkOrder> workOrders)
        {
            foreach (WorkOrder workOrder in workOrders)
            {
                switch(workOrder.Action)
                {
                    case 1:
                        WcfBusinessEntities.WorkOrderDb.Add(workOrder);
                        break;
                    case 2:
                        WcfBusinessEntities.WorkOrderDb.Update(workOrder);
                        break;
                }
            }
            
        }
    }
}
