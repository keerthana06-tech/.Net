using System.Diagnostics;
using interface_custom_service.Models;
using interface_custom_service.service;
using Microsoft.AspNetCore.Mvc;

namespace interface_custom_service.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _greet;

        public HomeController(IService greet)
        {
            _greet = greet;
        }

        public IActionResult Index()
        {
            var message = _greet.Getmessage("Keerthana");
            ViewBag.Message = message;
            return View();
        }

    }
}
