using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace ControleDeGastos.Web.Controllers
{
    public class LancamentoController : Controller
    {
        #region Atributos
        private readonly CategoriaService _categoriaService;
        private readonly CartaoService _cartaoService;
        private readonly LancamentoService _lancamentoService;
        private readonly UsuarioService _usuarioService;
        private readonly UserManager<UsuarioLogado> _userManager;
        #endregion

        #region Construtor
        public LancamentoController(CategoriaService categoriaService, CartaoService cartaoService, 
            LancamentoService lancamentoService, UsuarioService usuarioService, UserManager<UsuarioLogado> userManager)
        {
            _categoriaService = categoriaService;
            _cartaoService = cartaoService;
            _lancamentoService = lancamentoService;
            _usuarioService = usuarioService;
            _userManager = userManager;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Lancamentos = _lancamentoService.Listar(1);
            return View();
        }
        #endregion

        #region Cadastro
        public IActionResult Cadastro()
        {
            var teste = Convert.ToInt32(_userManager.GetUserId(User));
            ViewBag.Categorias = new SelectList(_categoriaService.ListarPorUsuario(Convert.ToInt32(_userManager.GetUserId(User))), "IdCategoria", "Titulo");
            ViewBag.Cartoes = new SelectList(_cartaoService.Listar(1), "IdCartao", "Banco");
            return View();
        }
        #endregion

        #region Cadastrar
        public IActionResult Cadastrar(Lancamento l)
        {
            if (ModelState.IsValid)
            {
                var usuario = _usuarioService.Obter(1);
                _lancamentoService.Cadastrar(l, usuario);
            }
            return View();
        }
        #endregion

        #region Edicao
        public IActionResult Edicao(int? idLancamento)
        {
            ViewBag.Categorias = new SelectList(_categoriaService.ListarPorUsuario(1), "IdCategoria", "Titulo");
            ViewBag.Cartoes = new SelectList(_cartaoService.Listar(1), "IdCartao", "Banco");
            return View(_lancamentoService.Obter(idLancamento));
        }
        #endregion

        #region Editar
        [HttpPost]
        public IActionResult Editar(Lancamento l)
        {
            _lancamentoService.Editar(l);
            return RedirectToAction("Index");
        }
        #endregion
    }
}