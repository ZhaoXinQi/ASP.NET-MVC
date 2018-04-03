using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbContextFactory
    {
        public static EntityModel CreateDbContext()
        {
          EntityModel  ModelEntity= CallContext.GetData("DbContext") as EntityModel;
            if (ModelEntity == null)
            {
                ModelEntity = new EntityModel();
                CallContext.SetData("DbContext", ModelEntity);
                return ModelEntity;
            }
            return ModelEntity;
        }
    }
}
