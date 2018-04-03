using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;
using Model;

namespace BLL
{
    public class BaseBLL<T> : IBaseBLL<T> where T : class, new()
    {
        public IBaseDAL<T> baseDAL;

        //构造函数注入
        public BaseBLL(IBaseDAL<T> ibaseDAL)
        {
            this.baseDAL = ibaseDAL;
        }

        public bool Add(T t)
        {
            baseDAL.Insert(t);
            return baseDAL.SavaChage();
        }

        public IEnumerable<T> GetEntities(Func<T, bool> whereLambda)
        {
            return baseDAL.SelectEntities(whereLambda);
        }

        public T GetEntity(Func<T, bool> whereLambda)
        {
            return baseDAL.SelectEntity(whereLambda);
        }

        public IEnumerable<T> GetEntityByPage<Ttype>(int pageIndex, int pageSize,bool isAsc,Expression<Func<T, Ttype>> orderByLambda, Expression<Func<T, bool>> whereLamdab)
        {
            return baseDAL.SelectEntitiesByPage(pageIndex, pageSize, isAsc, orderByLambda, whereLamdab);
        }

        public bool Modity(T t)
        {
            baseDAL.Update(t);
            return baseDAL.SavaChage();
        }

        public bool Remove(T t)
        {
            baseDAL.Delete(t);
            return baseDAL.SavaChage();
        }
    }
}
