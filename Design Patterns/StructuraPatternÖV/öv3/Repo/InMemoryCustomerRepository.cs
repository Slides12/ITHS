using öv3.Entities;
using öv3.Interface;

namespace öv3.Repo
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        List<Customer> customers = new List<Customer>() {
        
        new Customer() { id = 1, Name = "Daniel", Email = "Daniel@iths.se" },
        new Customer() { id = 2, Name = "Sofia", Email = "Sofia@iths.se" },
        new Customer() { id = 3, Name = "Bertil", Email = "Bertil@iths.se" },
        new Customer() { id = 4, Name = "Håkan", Email = "Håkan@iths.se" },
        new Customer() { id = 5, Name = "Anders", Email = "Anders@iths.se" },

        };

        public void Add(Customer newCustomer)
        {
            customers.Add(newCustomer);
        }

        public List<Customer> GetAll()
        {
            return customers;
        }

        public Customer GetById(int id)
        {
            var customer = customers.First(c => c.id == id);
            return customer;
        }
    }
}
