﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnMVC.DataAccessLayer;

namespace LearnMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();

            salesDal.Database.CreateIfNotExists();

            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
    }
}