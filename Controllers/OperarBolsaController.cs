using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc1.Models;

namespace pc1.Controllers
{
    public class OperarBolsaController : Controller
    {
        private readonly ILogger<OperarBolsaController> _logger;

        public OperarBolsaController(ILogger<OperarBolsaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["listaOperaciones"] = new List<OperarBolsa>();
            return View();
        }

        [HttpPost]
        public IActionResult Invertir(OperarBolsa operarbolsa)
        {
            List<OperarBolsa> listaOperaciones = new List<OperarBolsa>();
            operarbolsa.CalcularOperacion();
            listaOperaciones.Add(operarbolsa);
            ViewData["listaOperaciones"] = listaOperaciones;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}