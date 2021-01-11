using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_example.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string _name)
        {
            this.Name = _name;
        }
    }
}