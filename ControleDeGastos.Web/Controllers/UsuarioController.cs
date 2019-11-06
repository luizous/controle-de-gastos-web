using ControleDeGastos.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    [LayoutInjecter("_Layout")]
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}