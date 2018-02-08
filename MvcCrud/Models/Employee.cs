using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCrud.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CompanyID { get; set; }
    }
}