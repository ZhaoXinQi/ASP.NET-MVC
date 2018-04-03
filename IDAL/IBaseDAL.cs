using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDAL<T> where T:class ,new()
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        bool SavaChage();

        T SelectEntity(Func<T, bool> whereLambda);

        IEnumerable<T> SelectEntities(Func<T, bool> whereLambda);

        IEnumerable<T> SelectEntitiesByPage<Ttype>(int pageIndex, int pageSize, bool isAsc, Expression<Func<T, Ttype>> orderLambda, Expression<Func<T, bool>> whereLambda);
    }
}
