using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControleDeGastos.Models;
using ControleDeGastos.DAL.Interfaces;

namespace ControleDeGastos.Controllers
{
    public class HomeController : Controller
    {
        #region Atributos
        private readonly ILogger<HomeController> _logger;
        private readonly IUsuarioDAO _usuarioDAO;
        #endregion

        #region Construtor
        public HomeController(ILogger<HomeController> logger, IUsuarioDAO usuarioDAO)
        {
            _logger = logger;
            _usuarioDAO = usuarioDAO;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Logar
        public IActionResult Logar(string login, string senha)
        {
            var logar = _usuarioDAO.Logar(login, senha);
            if (!logar)
                ModelState.AddModelError("", "Usuário/E-mail ou senha incorretos!");
            return View("Dashboard");
        }
        #endregion

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
