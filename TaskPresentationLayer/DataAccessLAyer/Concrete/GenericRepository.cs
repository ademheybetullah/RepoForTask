using EntityLayer.Concrete;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly IMongoCollection<T> _collection;
        

        public GenericRepository()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://HeybetAdem:AM3nkmnDkYgXl6DF@dbfortask.dpwtvxu.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
        
            var database = client.GetDatabase("DBforTask");
            _collection = database.GetCollection<T>("TaskDb");
            
        }
       

        public List<T> getAllItems()
        {
            
            return _collection.AsQueryable().ToList();
        }
    }
}
