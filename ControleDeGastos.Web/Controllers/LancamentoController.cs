using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControleDeGastos.Web.Controllers
{
    public class LancamentoController : Controller
    {
        #region Atributos
        private readonly CategoriaService _categoriaService;
        private readonly LancamentoService _lancamentoService;
        private readonly UsuarioService _usuarioService;
        #endregion

        #region Construtor
        public LancamentoController(CategoriaService categoriaService, LancamentoService lancamentoService)
        {
            _categoriaService = categoriaService;
            _lancamentoService = lancamentoService;
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
            ViewBag.Categorias = new SelectList(_categoriaService.ListarPorUsuario(1), "IdCategoria", "Titulo");
            return View();
        }
        #endregion

        #region Cadastrar
        public IActionResult Cadastrar(Lancamento l)
        {
            Usuario usuario = _usuarioService.GetUsuarioLogado();
            if (ModelState.IsValid)
            {
                if (_lancamentoService.Cadastrar(l, usuario))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Este e-mail já está sendo utilizado!");
            }
            return View();
        }
        #endregion
    }
}