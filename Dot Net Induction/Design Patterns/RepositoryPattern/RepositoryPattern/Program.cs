using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<WorkOrder> repository = new WorkOrderRepository();
            var result = repository.List;
            foreach (var r in result)
            {
                Console.ReadLine(r.WONumber.ToString());
            }
        }
    }
    public class IEntity
    {
        public string id;
    }
}
