using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class RecebimentoController : Controller
    {
        #region Atributos
        private readonly RecebimentoService _recebimentoService;
        private readonly UsuarioService _usuarioService;
        #endregion

        #region Construtor
        public RecebimentoController(RecebimentoService recebimentoService, UsuarioService usuarioService)
        {
            _recebimentoService = recebimentoService;
            _usuarioService = usuarioService;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Recebimentos = _recebimentoService.Listar(1);
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
                var usuario = _usuarioService.Obter(1);
                _recebimentoService.Cadastrar(r, usuario);
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