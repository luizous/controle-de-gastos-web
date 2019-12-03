using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    [Authorize]
    //[Authorize(Roles = "USER")]
    public class CartaoController : Controller
    {
        #region Atributos
        private readonly CartaoService _cartaoService;
        private readonly UsuarioService _usuarioService;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public CartaoController(CartaoService cartaoService, UsuarioService usuarioService, UsuarioAutenticado usuarioAutenticado)
        {
            _cartaoService = cartaoService;
            _usuarioService = usuarioService;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Cartoes = _cartaoService.Listar(_usuarioAutenticado.IdUsuario(User));
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
        public IActionResult Cadastrar(Cartao c)
        {
            if (ModelState.IsValid)
            {
                var usuario = _usuarioService.Obter(_usuarioAutenticado.IdUsuario(User));
                _cartaoService.Cadastrar(c, usuario);
                return RedirectToAction("Index");
            }
            return View("Cadastro", c);
        }
        #endregion

        #region Remover
        public IActionResult Remover(int? idCartao)
        {
            if (idCartao != null)
            {
                _cartaoService.Remover(idCartao);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        #endregion
    }
}