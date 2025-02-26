
using BlazorAppDemo.Entities;

namespace BlazorAppDemo.Services
{
    public interface IPersonInfoService
    {
        Task<List<PersonInfoEntity>> GetAllPersons();
        Task<PersonInfoEntity> AddPerson(PersonInfoEntity pi);
    }
}
