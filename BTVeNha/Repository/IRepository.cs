using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVeNha.Repository
{
    public interface IRepository<T> where T:class
    {
        T Add(T entity);
        void Commit();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
