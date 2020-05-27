using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula03_MVC.Models;
using Aula03_MVC.Models.Domain;

namespace Aula03_MVC.Controllers
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

        public IActionResult Responde()
        {
            var p = new Pessoa();
            return View(p);
        }

        public IActionResult Sucesso(Pessoa psso)
        {
            var p = new Pessoa();
            return View(p);
        }
        public IActionResult Salva(Pessoa psso)
        {
            if (ModelState.IsValid)
            {
                return View("Sucesso", psso);
            }

            return View("Responde");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
