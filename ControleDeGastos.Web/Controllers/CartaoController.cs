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
            ViewBag.Cartoes = _cartaoService.Listar(_usuarioAutenticado.IdUsuario());
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
                var usuario = _usuarioService.Obter(_usuarioAutenticado.IdUsuario());
                _cartaoService.Cadastrar(c, usuario);
            }
            return View();
        }
        #endregion

        #region Remover
        public IActionResult Remover(int? idCartao)
        {
            if (idCartao != null)
            {
                _cartaoService.Remover(idCartao);
            }
            else
            {
                //Redirecionar para uma página de erro
            }
            return RedirectToAction("Index");
        }
        #endregion

        //[HttpPost]
        //public IActionResult ValidarCartao(Cartao c)
        //{
        //    //string url = "https://viacep.com.br/ws/" +
        //    //    u..Cep + "/json/";
        //    //WebClient client = new WebClient();
        //    //TempData["Endereco"] = client.DownloadString(url);

        //    return RedirectToAction(nameof(Cadastrar));
        //}
    }
}