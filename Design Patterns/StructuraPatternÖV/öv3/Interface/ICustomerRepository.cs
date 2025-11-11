using öv3.Entities;

namespace öv3.Interface
{
    public interface ICustomerRepository
    {
        void Add(Customer newCustomer);
        Customer GetById(int id);

        List<Customer> GetAll();
    }
}
