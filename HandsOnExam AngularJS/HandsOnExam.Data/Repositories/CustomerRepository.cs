using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnExam.Data.Infrastructure;
using HandsOnExam.Models.Dbo;

namespace HandsOnExam.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        public Customer GetCustomerById(int customerId)
        {
            using (var context = new HandsOnExamContext())
            {
                return context.Customers.Find(customerId);

            }

        }

        public List<Customer> GetAllCustomers()
        {
            using (var context = new HandsOnExamContext())
            {
                return context.Customers.ToList();

            }
        }

        public Customer DeletedCustomer(Customer Customer)
        {
            using (var context = new HandsOnExamContext())
            {
                context.Entry(Customer).State = EntityState.Deleted;
                context.SaveChanges();
                return Customer;

            }

        }

        public Customer AddCustomer(Customer Customer)
        {
            using (var context = new HandsOnExamContext())
            {
                context.Entry(Customer).State = EntityState.Added;
                context.SaveChanges();
                return Customer;

            }

        }

        public Customer EditCustomer(Customer Customer)
        {
            using (var context = new HandsOnExamContext())
            {
                context.Entry(Customer).State = EntityState.Modified;
                context.SaveChanges();
                return Customer;

            }

        }
    }
}