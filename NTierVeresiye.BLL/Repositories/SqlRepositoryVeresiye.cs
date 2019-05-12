using NTierVeresiye.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.BLL.Repositories
{
  public  class SqlRepositoryVeresiye<T> where T:class
    {
        SqlVeresiyeContext db = new SqlVeresiyeContext();
        public IQueryable<T> Listele()
        {
            return db.Set<T>(); 
        }
        public T IDGoreGetir(Expression<Func<T, bool>> ifade)
        {
            if (db.Set<T>().Any(ifade)) return db.Set<T>().Where(ifade).First();
            else return null;
        }
        public IQueryable<T> Listele(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression);
        }
        public void Insert(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public void Insert(List<T> entities)
        {
            db.Set<T>().AddRange(entities);
            db.SaveChanges();
        }
        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
        public void Delete(List<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
            db.SaveChanges();
        }
        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
        public List<T> Sorgula(string sorgu)
        {
            return db.Set<T>().SqlQuery(sorgu).ToList();

        }

        // dataGridViewUretici.DataSource = brandRepo.Sorgula("Select * from Brand").ToList();
    }
}
