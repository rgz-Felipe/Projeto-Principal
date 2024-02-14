using Microsoft.AspNetCore.Mvc;
using ProjetoPrincipal.Models;
using System.Diagnostics;

namespace ProjetoPrincipal.Controllers
{
    public class CadastrarAlunoController : Controller
    {
        private readonly ILogger<CadastrarAlunoController> _logger;

        public CadastrarAlunoController(ILogger<CadastrarAlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult CadastrarAluno()
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
