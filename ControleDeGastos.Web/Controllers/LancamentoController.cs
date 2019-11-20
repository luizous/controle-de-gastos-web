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
        private readonly UsuarioService _usuarioService;
        //private readonly Usuario usuario = _usuarioService.GetUsuarioLogado();
        #endregion

        #region Construtor
        public LancamentoController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
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
    }
}