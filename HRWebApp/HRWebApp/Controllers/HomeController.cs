using HRWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BOL;
using System.Collections.Generic;
using DAL;
using MySql.Data.MySqlClient;

namespace HRWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Employees() {

            List<Employee> List = DBManager.getAllEmployees();

            ViewBag.EmployeeList = List;
            return View();
        }
        [HttpPost]
        public IActionResult Register(string id, string empname, string designation, string department, string city, string salary,string joindate) {

            Employee employee= new Employee(int.Parse(id), empname, designation,Enum.Parse<Department>(department), city,double.Parse(salary),DateOnly.Parse(joindate));

            DBManager.insertEmployee(employee);

            return RedirectToAction("Employees");
        }

        public IActionResult Register() {
        return View();
        }
        public ActionResult Delete() { 
        return View();

        }
        [HttpPost]
        public IActionResult delete(int id)
        {

            DBManager.deleteEmployee(id);
            return RedirectToAction("Employees");
        }

        public IActionResult Update(string id) {
            Employee emp = DBManager.getById(int.Parse(id));
            if(emp != null)
            {
                ViewBag.Employee = emp;
                Console.WriteLine(emp);
                return View();
            }
            return RedirectToAction("Index");
        }
       
        public IActionResult UpdateEmp(string id, string empname, string designation, string department, string city, string salary,string joindate)
        {
            Employee e = new Employee(int.Parse(id),empname,designation,Enum.Parse<Department>(department),city,Double.Parse(salary),DateOnly.Parse(joindate));
            DBManager.UpdateEmp(e);
            return RedirectToAction("Employees");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}