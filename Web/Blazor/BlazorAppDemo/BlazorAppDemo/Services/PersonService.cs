using BlazorAppDemo.Data;
using BlazorAppDemo.Entities;

namespace BlazorAppDemo.Services
{
    public class PersonService : IPersonInfoService
    {
        private readonly SqlDbContext _db;

        public PersonService(SqlDbContext db)
        {
            _db = db;
        }

        public async Task<PersonInfoEntity> AddPerson(PersonInfoEntity pi)
        {
            _db.Persons.Add(pi);
            await _db.SaveChangesAsync();

            return pi;
        }

        public async Task<List<PersonInfoEntity>> GetAllPersons()
        {
            return _db.Persons.ToList();
        }

       

        
    }
}
