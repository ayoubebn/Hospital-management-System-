using Hospital.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Repositories.Interfaces
{
    internal interface IUnitOfWork
    {
        IGenericRepository<T> GenericRepository<T>() where T : class;
        void Save();
    }
}
