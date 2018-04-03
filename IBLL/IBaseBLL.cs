using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IBaseBLL<T>where T:class,new()
    {
        bool Add(T t);

        bool Modity(T t);

        bool Remove(T t);

        T GetEntity(Func<T, bool> whereLambda);

        IEnumerable<T> GetEntities(Func<T, bool> whereLambda);

        IEnumerable<T> GetEntityByPage<Ttype>(int pageIndex, int pageSize,bool isAse, Expression<Func<T, Ttype>> orderByLambda, Expression<Func<T, bool>> whereLamdab);
    }
}
