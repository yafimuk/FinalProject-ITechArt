﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Interfaces {

    public interface ITicketsRepository<T> : IRepository<T> where T : class {
        T GetById(int id);
    }
}
