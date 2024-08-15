using AppQuarta.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppQuarta.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastrarPessoa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarPessoa(Pessoa objpessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", objpessoa);
            }
            return View();
        }
        public IActionResult Resultado(Pessoa objpessoa)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastrarVeiculo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarVeiculo(Veiculo objveiculo)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoVeiculo", objveiculo);
            }
            return View();  
        }

        public IActionResult ResultadoVeiculo(Veiculo objveiculo)
        {
            return View();
        }
    }
}
