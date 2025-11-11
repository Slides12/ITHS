

using öv3.Repo;
using öv3.Service;

var customerDb = new InMemoryCustomerRepository();


var customerService = new CustomerService(customerDb);

customerService.GetAll();

customerService.AddCustomer(13, "Kajsa", "Kajsa@iths.se");

customerService.GetCustomerById(13);