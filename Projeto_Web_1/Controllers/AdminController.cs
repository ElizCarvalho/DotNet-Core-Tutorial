using Microsoft.AspNetCore.Mvc;

namespace Projeto_Web_1.Controllers
{
    [Route("Painel/Admin")]
    public class AdminController : Controller
    {

        // .../Painel/Admin/Eliz
        // .../Painel/Admin/Principal/Eliz/33
        [HttpGet("{nome}/{numero:int?}")] // ':int' estou tipando o parametro e o '?' torna opcional
        [HttpGet("Principal/{nome}/{numero:int?}")]
        public IActionResult Index(string nome, int numero = 99){
            return Content("Olá, eu sou o Olaf! Eu tenho " + numero + " anos. Tudo bem " + nome + " ?");
        }

        // .../Painel/Admin/Olafinho?nome=Eliz
        [HttpGet("Olafinho")] 
        public IActionResult Olaf(){
            var nome = Request.Query["nome"]; //query string
            return Content("Eu gosto de abraços quentinhos " + nome + " :)");
        }

        // .../Painel/Admin/Visualizar
        [HttpGet("Visualizar")]
        public IActionResult Visualizar(){
            ViewData["nome"] = "Eliz Carvalho";
            return View("VisuOlaf");
        }
    }
}