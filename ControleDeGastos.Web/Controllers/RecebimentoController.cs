using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class RecebimentoController : Controller
    {
        #region Atributos
        private readonly RecebimentoService _recebimentoService;
        private readonly UsuarioService _usuarioService;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public RecebimentoController(RecebimentoService recebimentoService, UsuarioService usuarioService, UsuarioAutenticado usuarioAutenticado)
        {
            _recebimentoService = recebimentoService;
            _usuarioService = usuarioService;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Recebimentos = _recebimentoService.Listar(_usuarioAutenticado.IdUsuario(User));
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
        public IActionResult Cadastrar(Recebimento r)
        {
            if (ModelState.IsValid)
            {
                _recebimentoService.Cadastrar(r, _usuarioAutenticado.Usuario(User));
            }
            return View();
        }
        #endregion

        #region Edicao
        public IActionResult Edicao(int? idRecebimento)
        {
            return View(_recebimentoService.Obter(idRecebimento));
        }
        #endregion

        #region Editar
        [HttpPost]
        public IActionResult Editar(Recebimento r)
        {
            _recebimentoService.Editar(r);
            return RedirectToAction("Index");
        }
        #endregion
    }
}