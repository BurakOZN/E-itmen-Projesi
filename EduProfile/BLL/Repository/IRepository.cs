using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public interface IRepository<T>
    {
        Task Add(T entity);
        Task Add(IEnumerable<T> entity);

        Task<List<T>> Get();
        Task<List<T>> Get(FilterDefinition<T> filter);
    }
    
}
