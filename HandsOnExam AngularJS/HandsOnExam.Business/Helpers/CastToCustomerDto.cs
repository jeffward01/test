using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnExam.Models.Dbo;
using HandsOnExam.Models.Dto;

namespace HandsOnExam.Business.Helpers
{
    public static class CastToCustomerDto
    {
        public static Customer_Dto CastToDto(Customer customer)
        {
            return new Customer_Dto
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                IsActive = customer.IsActive,
                LastName = customer.LastName,
                MiddleName = customer.MiddleName
            };

        }

        public static Customer CastToDbo(Customer_Dto customer)
        {
            return new Customer
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                IsActive = customer.IsActive,
                LastName = customer.LastName,
                MiddleName = customer.MiddleName
            };

        }
    }
}
