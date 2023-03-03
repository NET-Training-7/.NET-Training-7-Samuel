using Microsoft.AspNetCore.Mvc;
using StudentPortal.MVC.Models;
using System.Diagnostics;

namespace StudentPortal.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string CurrentTime()
        {
            return (DateTime.Now.ToString("MMMM dd,yyyy  hh:mm:ss"));
        }
        public string ABC()
        {
            return "Hello !!";
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //public IActionResult StudentList()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}