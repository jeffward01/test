using System.Collections.Generic;
using HandsOnExam.Models.Dbo;

namespace HandsOnExam.Data.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers();
        Customer DeletedCustomer(Customer Customer);
        Customer AddCustomer(Customer Customer);
        Customer EditCustomer(Customer Customer);
    }
}