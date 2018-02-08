﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCrud.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Employee> EmployeeList { get; set; }

        public Company()
        {
            ID = 1;
            Name = "TVL";
            Address = "Uttara, Dhaka";
            EmployeeList = new Employee().GetEmployees(); //new List<Employee>();
        }

        #region CRUD
        public List<Company> GetRandaomCompany()
        {
            var list = new List<Company>();
            for (int i = 0; i < 100; i++)
            {
                var model = new Company()
                {
                    ID = i + 1,
                    Name = "TVL " + i.ToString(),
                    Address = "Uttara, Dhaka - " + i.ToString(),
                    EmployeeList = new Employee().GetEmployees()
                };
                list.Add(model);
            }
            return list;
        }

        

        public Company GetCompany(int ID)
        {
            //ToDo: DB access

            return new Company();
        }

        public bool SaveCompany(Company company)
        {
            //ToDo: DB access

            return true;
        }

        public bool DeleteCompany(int ID)
        {
            //ToDo: DB access

            return true;
        }
        #endregion
    }
}