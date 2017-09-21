using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnExam.Data.Infrastructure;
using HandsOnExam.Data.Repositories;
using HandsOnExam.Models.Dbo;

namespace HandsOnExam.Business.Managers
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetCustomerById(customerId);

        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public Customer DeletedCustomer(int customerid)
        {

            return _customerRepository.DeletedCustomer(_customerRepository.GetCustomerById(customerid));

        }

        public Customer AddCustomer(Customer Customer)
        {
            return _customerRepository.AddCustomer(Customer);


        }

        public Customer EditCustomer(Customer Customer)
        {
            return _customerRepository.EditCustomer(Customer);


        }
    }
}
