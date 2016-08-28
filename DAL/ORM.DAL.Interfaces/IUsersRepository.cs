using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Interfaces {
    public interface IUsersRepository<T> : IRepository<T> where T : class {
    }
}
