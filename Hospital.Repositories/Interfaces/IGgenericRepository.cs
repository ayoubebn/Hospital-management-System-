using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Repositories.Interfaces
{
    public interface IGgenericRepository<T> : IDisposable
    { 
        IEnumerable<T> GetAll (
        Expression<Func<T, bool>> filtre = null,
        String includeProperties ="");


    T GetById(object id);
    Task<T> GetByIdAsync(object id);
    void Update(Task entity);
    Task<T> UpdateAsync(Task entity);
    void Delete(Task entity);
    Task<T> DeletAsunc(Task entity);
    
    }
}
