using öv4.Entities;

namespace öv4.Interface
{
    public interface ICustomerRepository
    {
        void Add(Customer newCustomer);
        Customer GetById(int id);

        List<Customer> GetAll();
    }
}
