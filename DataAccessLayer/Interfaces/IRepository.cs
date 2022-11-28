using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetByID(int id);
        T Add(T item);
        void Update(T item);
        void Delete(T id);
    }
}
