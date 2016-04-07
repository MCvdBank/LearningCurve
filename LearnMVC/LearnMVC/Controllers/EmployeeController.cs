using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Models;
using LearnMVC.ViewModels;

namespace LearnMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public string GetString()
        {
            return "Hello MVC";
        }

        public ActionResult Index()
        {
            /// User BusinessLayer
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString();
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

            return View("Index", employeeListViewModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("CreateEmployee");
                    }
                    break;
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
    }
}