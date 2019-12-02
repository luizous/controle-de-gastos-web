using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        #region Atributos
        private readonly CategoriaService _categoriaService;
        private readonly UsuarioService _usuarioService;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public CategoriaController(CategoriaService categoriaService, UsuarioService usuarioService,
            UsuarioAutenticado usuarioAutenticado)
        {
            _categoriaService = categoriaService;
            _usuarioService = usuarioService;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Categorias = _categoriaService.ListarPorUsuario(_usuarioAutenticado.IdUsuario(User));
            return View();
        }
        #endregion

        #region Cadastrar
        public IActionResult Cadastrar(Categoria c)
        {
            if (ModelState.IsValid)
            {
                _categoriaService.Cadastrar(c, _usuarioAutenticado.Usuario(User));
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
            return RedirectToAction("Perfil", "Usuario");
        }
        #endregion
    }
}