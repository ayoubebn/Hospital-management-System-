using Hospital.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Repositories.Implementation
{
    public class UnitOfWhok : IUnitOfWhok ,IDisposable
    {
        private readonly ApplicationDbContext _countext;

        public UnitOfWhok(ApplicationDbContext countext)
        {
            _countext = countext;
        }
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _countext.Dispose();
                }
                this.disposed = true;
            } 
        }
        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            IGenericRepository<T> repo = new GenericRepository<T>(_countext);
            return repo;

        }
        public void Save()
        {
            _countext.SaveChanges();
        }

    }
}
