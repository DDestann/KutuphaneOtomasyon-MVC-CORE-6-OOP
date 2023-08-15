using MvcCoreKutuphane.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Bussines.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T,bool>> filter=null);
        IEnumerable<T> Include(string include);
        IEnumerable<T> Include(string include, string include2);
        IEnumerable<T> Include(string include, string include2,string include3);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);


    }
}
