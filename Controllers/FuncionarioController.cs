using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioDAL funci;

        public FuncionarioController(IFuncionarioDAL logger)
        {
            funci = logger;
        }

        public IActionResult Index()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            listaFuncionarios = funci.GetAllFuncionarios().ToList();
            return View(listaFuncionarios);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
