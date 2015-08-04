using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfData;
namespace WcfBusinessEntities
{
    public static class WorkOrderDb
    {
        public static void Add(WorkOrder workOrder)
        {

            WcfData.WorkOrder inDbWorkOrder = (WcfData.WorkOrder)workOrder;
            WcfData.WorkOrderDbOperations.Add(inDbWorkOrder);
        }
        public static void Update(WorkOrder workOrder)
        {
            WcfData.WorkOrder inDbWorkOrder = (WcfData.WorkOrder)workOrder;
            WcfData.WorkOrderDbOperations.Update(inDbWorkOrder);
        }
    
        }


    }

