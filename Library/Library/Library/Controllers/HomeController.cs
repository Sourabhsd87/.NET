using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DAL;
using BOL;
using System.Collections.Generic;
namespace Library.Controllers
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

        public IActionResult bookList() {

            List<Book> bookList = DBManager.getAllBooks();
            foreach (Book b in bookList)
            {
                Console.WriteLine(b);
            }
            ViewBag.Booklist = bookList;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}