using Microsoft.EntityFrameworkCore;
using MvcCoreKutuphane.AppData.AppDataContext;
using MvcCoreKutuphane.Bussines.Interface;
using MvcCoreKutuphane.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreKutuphane.Bussines.Manager
{
    public class RepositoryManager<T> : IRepository<T> where T : BaseEntity
    {
        KutuphaneContextDb db;
        DbSet<T> Dbset;
        public RepositoryManager() 
        { 
            db = new KutuphaneContextDb();
            Dbset = db.Set<T>();
        }

        public void Delete(int id)
        {
              Dbset.Remove(Dbset.FirstOrDefault(x => x.Id == id));

            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            var list = Dbset.ToList();
            if (list.Count>0)
            {
                return list;
            }
            return new List<T>();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            var list = Dbset.Where(filter).ToList();
            if (list.Count > 0)
            {
                return list;
            }
            return new List<T>();
        }

        public T GetById(int id)
        {
            return Dbset.Find(id);
        }

        public IEnumerable<T> Include(string include)
        {
            return Dbset.Include(include).ToList();
        }

        public IEnumerable<T> Include(string include, string include2)
        {
            return Dbset.Include(include).Include(include2).ToList();
        }

        public IEnumerable<T> Include(string include, string include2, string include3)
        {
            return Dbset.Include(include).Include(include2).Include(include3).ToList();
        }

        public void Insert(T entity)
        {
           Dbset.Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            Dbset.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
