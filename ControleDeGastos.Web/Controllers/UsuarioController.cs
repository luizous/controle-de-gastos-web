using ControleDeGastos.Domain;
using ControleDeGastos.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class UsuarioController : Controller
    {
        #region Atributos
        private readonly UsuarioService _usuarioService;
        #endregion

        #region Construtor
        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        #endregion

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

        #region Cadastrar
        [HttpPost]
        public IActionResult Cadastrar(Usuario u)
        {
            if (ModelState.IsValid)
            {
                if (_usuarioService.Cadastrar(u))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Este e-mail já está sendo utilizado!");
            }
            return View(u);
        }
        #endregion

        #region Logar
        [HttpPost]
        public IActionResult Logar(string login, string senha)
        {
            if (ModelState.IsValid)
            {
                if (_usuarioService.Logar(login, senha))
                {
                    return RedirectToAction("Dashboard");
                }
                ModelState.AddModelError("", "E-mail ou senha incorretos.");
            }
            return View();
        }
        #endregion

        #region Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
        #endregion
    }
}