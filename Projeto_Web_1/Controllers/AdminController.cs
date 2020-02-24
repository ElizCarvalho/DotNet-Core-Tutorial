using Microsoft.AspNetCore.Mvc;

namespace Projeto_Web_1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(){
            return Content("Olá, eu sou o Olaf!");
        }

        public IActionResult Olaf(){
            return Content("Eu gosto de abraços quentinhos :)");
        }
    }
}