using System;
using MongoDB.Driver;
using MongoRepository.Domain.Entities;

namespace MongoRepository.Persistence.Repositories
{
    public class PersonRepository : BaseMongoRepository<Person>
    {
        private const string PeopleCollectionName = "People";

        private readonly MongoDataContext _dataContext;

        public PersonRepository(MongoDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        protected override IMongoCollection<Person> Collection => _dataContext.MongoDatabase.GetCollection<Person>(PeopleCollectionName);
    }
}
