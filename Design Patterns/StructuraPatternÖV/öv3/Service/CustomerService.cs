using öv3.Entities;
using öv3.Interface;

namespace öv3.Service
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void GetAll()
        {
            var customer = _customerRepository.GetAll();
            foreach (var item in customer)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void GetCustomerById(int id)
        {
            Console.WriteLine(_customerRepository.GetById(id).Name);
        }

        public void AddCustomer(int id, string name, string email)
        {
            _customerRepository.Add(new Customer() { id = id, Name = name, Email = email });
        }
    }
}
