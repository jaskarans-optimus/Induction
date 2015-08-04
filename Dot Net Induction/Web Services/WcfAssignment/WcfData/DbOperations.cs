using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfData
{
    public static class DbOperations
    {
        public static void Add(Operation operation)
        {
            using (var context = new WorkLoadDatabaseEntity())
            {
                try
                {
                    context.Operations.Add(operation);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public static void Update(Operation operation)
        {
            Operation inDbOperation;
            using (var context = new WorkLoadDatabaseEntity())
            {
                inDbOperation = (from s in context.Operations
                                 where s.OpId == operation.OpId
                                 select s).FirstOrDefault();
                if (operation.OpDesc != null)
                {
                    inDbOperation.OpDesc = operation.OpDesc;
                }
                if (operation.OpStatus != null)
                {
                    inDbOperation.OpStatus = operation.OpStatus;
                }
                if (operation.OpCompletionDate != null)
                {
                    inDbOperation.OpCompletionDate = operation.OpCompletionDate;
                }
                if (operation.WONumber != null)
                {
                    inDbOperation.WONumber = operation.WONumber;
                }
                context.SaveChanges();
            }
        }

    }
}
