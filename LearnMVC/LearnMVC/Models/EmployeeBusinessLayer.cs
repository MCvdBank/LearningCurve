using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee emp = new Employee();
            emp.FirstName = "MC";
            emp.LastName = "van der Bank";
            emp.Salary = 10000;
            employees.Add(emp);

            Employee emp1 = new Employee();
            emp1.FirstName = "RM";
            emp1.LastName = "Lombaard";
            emp1.Salary = 20000;
            employees.Add(emp1);

            return employees;
        }
    }
}