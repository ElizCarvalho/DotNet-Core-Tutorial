using Microsoft.AspNetCore.Mvc;

namespace Projeto_Web_1.Controllers
{
    [Route("Painel/Admin")]
    public class AdminController : Controller
    {

        [HttpGet("{nome}/{numero:int?}")] // ':int' estou tipando o parametro e o '?' torna opcional
        [HttpGet("Principal/{nome}/{numero:int?}")]
        public IActionResult Index(string nome, int numero = 99){
            return Content("Olá, eu sou o Olaf! Eu tenho " + numero + " anos. Tudo bem " + nome + " ?");
        }

        [HttpGet("Olafinho")]
        public IActionResult Olaf(){
            return Content("Eu gosto de abraços quentinhos :)");
        }
    }
}