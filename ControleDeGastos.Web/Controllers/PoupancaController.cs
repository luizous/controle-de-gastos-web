using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class PoupancaController : Controller
    {
        #region Atributos
        private readonly PoupancaService _poupancaService;
        private readonly UsuarioService _usuarioService;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public PoupancaController(PoupancaService poupancaService, UsuarioService usuarioService, UsuarioAutenticado usuarioAutenticado)
        {
            _poupancaService = poupancaService;
            _usuarioService = usuarioService;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Poupancas = _poupancaService.Listar(_usuarioAutenticado.IdUsuario(User));
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
        public IActionResult Cadastrar(Poupanca p)
        {
            if (ModelState.IsValid)
            {
                _poupancaService.Cadastrar(p, _usuarioAutenticado.Usuario(User));
            }
            return View();
        }
        #endregion

        #region Edicao
        public IActionResult Edicao(int? idPoupanca)
        {
            return View(_poupancaService.Obter(idPoupanca));
        }
        #endregion

        #region Editar
        [HttpPost]
        public IActionResult Editar(Poupanca p)
        {
            _poupancaService.Editar(p);
            return RedirectToAction("Index");
        }
        #endregion
    }
}