using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCCSaude__.Controllers
{
    public class TelaPrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
