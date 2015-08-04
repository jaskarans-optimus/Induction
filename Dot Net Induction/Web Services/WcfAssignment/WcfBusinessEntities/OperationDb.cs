using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfBusinessEntities
{
    public static class OperationDb
    {
        public static void Add(Operation operation)
        {
            WcfData.Operation inDbOperation = (WcfData.Operation)operation;
            WcfData.DbOperations.Add(inDbOperation);
        }
        public static void Update(Operation operation)
        {
            WcfData.Operation inDbOperation = (WcfData.Operation)operation;
            WcfData.DbOperations.Update(inDbOperation);
        }
    }
}
