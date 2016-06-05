using System;
using System.Threading.Tasks;
using MongoRepository.Domain.Entities;
using MongoRepository.Persistence;
using MongoRepository.Persistence.Repositories;

namespace MongoRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MainAsync();
            t.Wait();

            Console.ReadKey();
        }

        static async Task MainAsync()
        {
            var p = new Person()
            {
                FirstName = "John",
                LastName = "Smith"
            };

            var context = new MongoDataContext();
            var personRepository = new PersonRepository(context);

            await personRepository.SaveAsync(p);

            var personFromDatabase = await personRepository.GetByIdAsync(p.Id);

            Console.WriteLine($"{personFromDatabase.FirstName}, {personFromDatabase.LastName}, id: {personFromDatabase.Id}");
        }
    }
}
