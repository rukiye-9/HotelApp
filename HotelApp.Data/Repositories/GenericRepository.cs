using HotelApp.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Data.Repositories
{
    public class GenericRepository<T> : IGenericClass<T> where T : class
    {
        public void Delete(T t)
        {
            using var context = new DBContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var context = new DBContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new DBContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new DBContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new DBContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
