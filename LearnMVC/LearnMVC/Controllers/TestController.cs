using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Models;
using LearnMVC.ViewModels;

namespace LearnMVC.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello MVC";
        }

        public ActionResult GetView()
        {
            /// Use ViewModel
            /*
            Employee emp = new Employee();
            emp.FirstName = "MC";
            emp.LastName = "van der Bank";
            emp.Salary = 20000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "green";
            }
            else
            {
                vmEmp.SalaryColor = "yellow";
            }
            
            return View("MyView", vmEmp);
            */

            /// User BusinessLayer
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "green";
                }
                else
                {
                    empViewModel.SalaryColor = "yellow";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "@dmin_Dud3";

            return View("MyView", employeeListViewModel);
        }


    }
}