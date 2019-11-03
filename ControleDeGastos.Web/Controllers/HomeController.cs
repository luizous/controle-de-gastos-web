using Microsoft.AspNetCore.Mvc;
using ControleDeGastos.Web.Helper;

namespace ControleDeGastos.Web.Controllers
{
    public class HomeController : Controller
    {
        [LayoutInjecter("_LayoutLogin")]
        public IActionResult Index()
        {
            return View("Login");
        }
    }
}
