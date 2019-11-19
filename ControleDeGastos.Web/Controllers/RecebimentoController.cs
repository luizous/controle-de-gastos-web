using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class RecebimentoController : Controller
    {
        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }
        #endregion
    }
}