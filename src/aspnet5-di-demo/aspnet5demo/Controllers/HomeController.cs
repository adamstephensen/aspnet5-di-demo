using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using aspnet5demo.Models;

namespace aspnet5demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageGenerator _messageGenerator;
        
        public HomeController(IMessageGenerator messageGenerator)
        {
            _messageGenerator = messageGenerator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = _messageGenerator.GetWelcomeMessage("World");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
