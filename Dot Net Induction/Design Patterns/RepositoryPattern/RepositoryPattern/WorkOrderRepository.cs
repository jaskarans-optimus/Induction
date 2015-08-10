using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class WorkOrderRepository:IRepository<WorkOrder>
    {
        WcfDatabaseEntities entities;
        public WorkOrderRepository()
        {
            entities = new WcfDatabaseEntities();
        }
        public IEnumerable<WorkOrder> List
        {
            get
            {
                return entities.WorkOrders;
            }
        }
        void Add(WorkOrder entity)
        {
            entities.WorkOrders.Add(entity);
            entities.SaveChanges();
        }
        void Delete(WorkOrder entity)
        {
            entities.WorkOrders.Remove(entity);
            entities.SaveChanges();
        }
        void Update(WorkOrder entity)
        {
            entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
        }
        WorkOrder FindById(int id)
        {
            var result = (from r in entities.WorkOrders where r.WONumber == id select r).FirstOrDefault();
            return result;
        }
    }
}
