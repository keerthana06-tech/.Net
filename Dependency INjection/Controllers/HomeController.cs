using System.Diagnostics;
using Dependency_Injection.Models;
using Dependency_Injection.services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _service;

        public HomeController(IMyService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            string message = _service.GetMessage();
            return Content(message);

        }
    }
}
