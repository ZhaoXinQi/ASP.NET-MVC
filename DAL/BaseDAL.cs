using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;
using System.Data.Entity;

namespace DAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : class, new()
    {
        public readonly EntityModel ModelEntity = DbContextFactory.CreateDbContext();

        public DbSet<T> dbset;

        public BaseDAL()
        {
            dbset = ModelEntity.Set<T>();
        }


        public void Delete(T t)
        {
            dbset.Attach(t);
            dbset.Remove(t);
        }

        public void Insert(T t)
        {
            dbset.Add(t);
        }

        public bool SavaChage()
        {
            return ModelEntity.SaveChanges() > 0;
        }

        public IEnumerable<T> SelectEntities(Func<T, bool> whereLambda)
        {
            return dbset.Where(whereLambda);
        }

        public IEnumerable<T> SelectEntitiesByPage<Ttype>(int pageIndex, int pageSize, bool isAsc, Expression<Func<T, Ttype>> orderLambda, Expression<Func<T, bool>> whereLambda)
        {
            //查询出来多个实体
            var result = dbset.Where(whereLambda);
            //判断按哪种方式排序
            result = isAsc ? result.OrderBy(orderLambda) : result.OrderByDescending(orderLambda);
            //每页显示个数
            result = result.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return result.ToList();
        }

        public T SelectEntity(Func<T, bool> whereLambda)
        {
            return dbset.FirstOrDefault(whereLambda);
        }

        public void Update(T t)
        {
            dbset.Attach(t);
            ModelEntity.Entry(t).State = EntityState.Modified;
        }
    }
}
