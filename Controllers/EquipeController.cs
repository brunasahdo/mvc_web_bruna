using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult é um tipo vindo da classe controller. Dá o "status de resposta HTTP"(?)
        public IActionResult Index()
        {
            return View();
        }
    }
}
