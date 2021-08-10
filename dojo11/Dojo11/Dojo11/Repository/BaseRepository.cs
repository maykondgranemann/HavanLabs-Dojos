using Dojo11.Context;
using Dojo11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo11.Repository
{
    public abstract class BaseRepository <T> where T:BaseModels
    {
        public void Create(T model)
        {
            using (var context = new BaseContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            List<T> lista = new List<T>();
            using (var context = new BaseContext())
            {
                lista = context.Set<T>().ToList();
            }
            return lista;
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new BaseContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public void Update(T model)
        {
            using (var context = new BaseContext())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new BaseContext())
            {
                context.Entry<T>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
