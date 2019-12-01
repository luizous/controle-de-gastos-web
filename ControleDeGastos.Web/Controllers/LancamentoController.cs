using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
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
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public LancamentoController(CategoriaService categoriaService, CartaoService cartaoService, 
            LancamentoService lancamentoService, UsuarioAutenticado usuarioAutenticado)
        {
            _categoriaService = categoriaService;
            _cartaoService = cartaoService;
            _lancamentoService = lancamentoService;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Lancamentos = _lancamentoService.Listar(_usuarioAutenticado.IdUsuario(User));
            foreach (var item in ViewBag.Lancamentos)
            {
                ViewBag.Categoria = _categoriaService.Obter(item.Categoria.IdCategoria).Titulo;
                ViewBag.Cartao = _cartaoService.Obter(item.Cartao.IdCartao).Banco;
            }
            return View();
        }
        #endregion

        #region Cadastro
        public IActionResult Cadastro()
        {
            ViewBag.Categorias = new SelectList(_categoriaService.ListarPorUsuario(_usuarioAutenticado.IdUsuario(User)), "IdCategoria", "Titulo");
            ViewBag.Cartoes = new SelectList(_cartaoService.Listar(1), "IdCartao", "Banco");
            return View();
        }
        #endregion

        #region Cadastrar
        public IActionResult Cadastrar(Lancamento l, int drpCategorias, int drpCartoes)
        {
            if (ModelState.IsValid)
            {
                l.Categoria = _categoriaService.Obter(drpCategorias);
                l.Cartao = _cartaoService.Obter(drpCartoes);
                _lancamentoService.Cadastrar(l, _usuarioAutenticado.Usuario(User));
            }
            return View();
        }
        #endregion

        #region Edicao
        public IActionResult Edicao(int? idLancamento)
        {
            ViewBag.Categorias = new SelectList(_categoriaService.ListarPorUsuario(_usuarioAutenticado.IdUsuario(User)), "IdCategoria", "Titulo");
            ViewBag.Cartoes = new SelectList(_cartaoService.Listar(_usuarioAutenticado.IdUsuario(User)), "IdCartao", "Banco");
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