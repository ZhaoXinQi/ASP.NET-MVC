using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;

namespace BLL
{
    public class IndexBLL : BaseBLL<Job>, IIndexBLL
    {
        public IndexBLL(IBaseDAL<Job> ibaseDAL) : base(ibaseDAL)
        {
        }
    }
}
