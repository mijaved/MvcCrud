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
        public DateTime DateOfBirth { get; set; }
        public bool IsAtive { get; set; }
        public int CompanyID { get; set; }

        public List<Employee> GetEmployees()
        {
            var empList = new List<Employee>();
            Employee emp = null;
            for (int i = 0; i < 5; i++)
            {
                emp = new Employee()
                {
                    CompanyID = 1,
                    EmployeeID = 1 + i,
                    Name = "Name " + i.ToString(),
                    Email = "Email " + i.ToString(),
                    Phone = "Phone " + i.ToString(),
                    Position = "Position " + i.ToString(),
                    DateOfBirth = DateTime.Now.AddYears(-(20+i)),
                    IsAtive = (i%2==0?true:false)
                };

                empList.Add(emp);
            }
            return empList;
        }
    }
}