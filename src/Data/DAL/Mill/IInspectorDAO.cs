using Domain.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DummyReposytory
{
    public class UserRepository : IUserRepository
    {

       public Domain.Entity.Setup.User Get(int key)
       {
          throw new NotImplementedException();
       }

       public void SaveOrUpdate(Domain.Entity.Setup.User entity)
       {
          throw new NotImplementedException();
       }

       public void Delete(Domain.Entity.Setup.User entity)
       {
          throw new NotImplementedException();
       }

       public void Evict(Domain.Entity.Setup.User entity)
       {
          throw new NotImplementedException();
       }


       public void Flush()
       {
          throw new NotImplementedException();
       }

       public void BeginTransaction()
       {
          throw new NotImplementedException();
       }

       public void Commit()
       {
          throw new NotImplementedException();
       }

       public void Rollback()
       {
          throw new NotImplementedException();
       }

       public bool IsTransactionActive()
       {
          throw new NotImplementedException();
       }


       public void Save(Domain.Entity.Setup.User entity)
       {
          throw new NotImplementedException();
       }

       public void Dispose()
       {
          throw new NotImplementedException();
       }
    }
}
