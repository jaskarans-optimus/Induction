using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public interface IRepository<T> where T:IEntity
    {
        IEnumerable<T> List { get; }
        void Add(IEntity T);
        void Update(IEntity T);
        void Delete(IEntity T);
        T FindById(int id);
    }
}
