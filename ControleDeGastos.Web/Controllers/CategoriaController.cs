using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class CategoriaController : Controller
    {
        #region Atributos
        private readonly CategoriaService _categoriaService;
        private readonly UsuarioService _usuarioService;
        #endregion

        #region Construtor
        public CategoriaController(CategoriaService categoriaService, UsuarioService usuarioService)
        {
            _categoriaService = categoriaService;
            _usuarioService = usuarioService;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Categorias = _categoriaService.ListarPorUsuario(1);
            return View();
        }
        #endregion

        #region Cadastrar
        public IActionResult Cadastrar(Categoria c)
        {
            if (ModelState.IsValid)
            {
                ////// ----------> COLOCAR O USUARIO LOGADO (ABAIXO) CORRETAMENTE <---------
                var usuario = _usuarioService.Obter(1);
                _categoriaService.Cadastrar(c, usuario);
            }
            return View(c);
        }
        #endregion

        #region Remover
        public IActionResult Remover(int? idCategoria)
        {
            if (idCategoria != null)
            {
                _categoriaService.Remover(idCategoria);
            }
            else
            {
                //Redirecionar para uma página de erro
            }
            return RedirectToAction("Index");
        }
        #endregion
    }
}