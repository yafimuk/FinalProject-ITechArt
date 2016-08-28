using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Interfaces {
    public interface IUserTicketsRepository<T> : IRepository<T> where T : class {
        bool DeleteById(int id);
    }
}
