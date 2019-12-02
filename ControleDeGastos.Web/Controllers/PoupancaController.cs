using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControleDeGastos.Web.Controllers
{
    [Authorize]
    public class PoupancaController : Controller
    {
        #region Atributos
        private readonly PoupancaService _poupancaService;
        private readonly UsuarioService _usuarioService;
        private readonly CartaoService _cartaoService;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public PoupancaController(PoupancaService poupancaService, UsuarioService usuarioService, UsuarioAutenticado usuarioAutenticado,
            CartaoService cartaoService)
        {
            _poupancaService = poupancaService;
            _usuarioService = usuarioService;
            _cartaoService = cartaoService;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Poupancas = _poupancaService.Listar(_usuarioAutenticado.IdUsuario(User));
            foreach (var poupanca in ViewBag.Poupancas)
            {
                var cartao = _cartaoService.Obter(poupanca.Cartao.IdCartao);
                ViewBag.Banco = cartao.Banco;
            }
            return View();
        }
        #endregion

        #region Cadastro
        public IActionResult Cadastro()
        {
            ViewBag.Cartoes = new SelectList(_cartaoService.Listar(_usuarioAutenticado.IdUsuario(User)), "IdCartao", "Banco");
            return View();
        }
        #endregion

        #region Cadastrar
        [HttpPost]
        public IActionResult Cadastrar(Poupanca p, int drpCartoes)
        {
            if (ModelState.IsValid)
            {
                p.Cartao = _cartaoService.Obter(drpCartoes);
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