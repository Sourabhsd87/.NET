using ABCD.Models;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using EmployeeManagementSystem.Presistant;

namespace ABCD.Controllers
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

        public IActionResult Login() { 

        return View();

        }
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            Console.WriteLine("in login controller");
            if(email=="sdsd@gmail.com" && password=="sdsdsd")
            {
                Console.WriteLine("in sdsd");
                return RedirectToAction("Index");
            }

            return View();

        }
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstName,string lastName,string email,string password,string contactNo) {


            Employee e = new Employee(firstName, lastName, email, password,contactNo);
            List<Employee> list = new List<Employee>();
            list.Add(e);
            //var option = new JsonSerializerOptions { IncludeFields = true };
            //var empjson = JsonSerializer.Serialize<List<Employee>>(list, option);
            //string fileName = @"D:\dotNet\Day7_practice\ABCD\employeeData.json";
            //File
            Serializing.serialize(list);

            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}