using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_example.Models;

namespace WebAPI_example.Controllers
{
    public class CustomerController : ApiController
    {
        private static List<Customer> customers = new List<Customer>();

        [HttpGet]
        public List<Customer> GetCustomers()
        {
            return customers;
        }

        [HttpPost]
        public void InsertCustomer(string _name)
        {
            if (!String.IsNullOrEmpty(_name))
                customers.Add(new Customer(_name));
        }

        [HttpDelete]
        public void DeleteCustomer(string _name)
        {
            customers.Remove(customers.FirstOrDefault(c => c.Name.Equals(_name)));
        }

    }
}
