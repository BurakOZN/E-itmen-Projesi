using DAL;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class BaseRepository<T> : IRepository<T>
    {
        IMongoCollection<T> Collection { get { return Context.Instance.database.GetCollection<T>(typeof(T).Name); } }
        
        public Task Add(T entity)
        {
            var a = Collection.InsertOneAsync(entity);
            return a;
        }

        public Task Add(IEnumerable<T> entity)
        {
            var a = Collection.InsertManyAsync(entity);
            return a;
        }

        public async Task<List<T>> Get()
        {
            var filter = Builders<T>.Filter.Empty;;
            var a = await Collection.Find(filter).ToListAsync();
            return a;
        }

        public async Task<List<T>> Get(FilterDefinition<T> filter)
        {
            var a = await Collection.Find(filter).ToListAsync();
            return a;
        }
    }
}
