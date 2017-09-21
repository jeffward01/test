using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using HandsOnExam.Business.Managers;
using HandsOnExam.Models.Dbo;

namespace HandsOnExam.API.Controllers
{
    [System.Web.Http.RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        private readonly ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        
        [Route("GetAllCustomers")]
        [HttpGet]
        public IHttpActionResult GetAllCustomers()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_customerManager.GetAllCustomers());
        }

        [Route("GetCustomerById/{customerId}")]
        [HttpGet]
        public IHttpActionResult GetCustomerById(int customerId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_customerManager.GetCustomerById(customerId));
        }

        [Route("DeleteCustomer/{customerId}")]
        [HttpPost]
        public IHttpActionResult Get(int customerId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_customerManager.DeletedCustomer(customerId));
        }

        [Route("EditCustomer")]
        [HttpPost]
        public IHttpActionResult EditCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_customerManager.EditCustomer(customer));
        }

        [Route("AddCustomer")]
        [HttpPost]
        public IHttpActionResult AddCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_customerManager.AddCustomer(customer));
        }
    }
}