using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ControleDeGastos.Web.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        #region Atributos
        private readonly CategoriaService _categoriaService;
        private readonly UsuarioService _usuarioService;
        private readonly UserManager<UsuarioLogado> _userManager;
        #endregion

        #region Construtor
        public CategoriaController(CategoriaService categoriaService, UsuarioService usuarioService,
            UserManager<UsuarioLogado> userManager)
        {
            _categoriaService = categoriaService;
            _usuarioService = usuarioService;
            _userManager = userManager;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            var usuario = _usuarioService.ObterPorToken(Guid.Parse(_userManager.GetUserId(User)));
            ViewBag.Categorias = _categoriaService.ListarPorUsuario(usuario.IdUsuario);
            return View();
        }
        #endregion

        #region Cadastrar
        public IActionResult Cadastrar(Categoria c)
        {
            if (ModelState.IsValid)
            {
                var usuario = _usuarioService.ObterPorToken(Guid.Parse(_userManager.GetUserId(User)));
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