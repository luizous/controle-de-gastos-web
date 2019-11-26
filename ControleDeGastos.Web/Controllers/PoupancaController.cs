using ControleDeGastos.Service;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class PoupancaController : Controller
    {
        #region Atributos
        private readonly PoupancaService _poupancaService;
        private readonly UsuarioService _usuarioService;
        #endregion

        #region Construtor
        public PoupancaController(PoupancaService poupancaService, UsuarioService usuarioService)
        {
            _poupancaService = poupancaService;
            _usuarioService = usuarioService;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Poupancas = _poupancaService.Listar(1);
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
                var usuario = _usuarioService.Obter(1);
                _poupancaService.Cadastrar(r, usuario);
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