using System.Collections.Generic;
using HandsOnExam.Models.Dbo;

namespace HandsOnExam.Business.Managers
{
    public interface ICustomerManager
    {
        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers();
        Customer DeletedCustomer(int customerid);
        Customer AddCustomer(Customer Customer);
        Customer EditCustomer(Customer Customer);
    }
}