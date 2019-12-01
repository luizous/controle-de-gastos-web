using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    public class RelatorioController : Controller
    {
        #region Atributos
        private readonly UsuarioService _usuarioService;
        private readonly LancamentoService _lancamentoService;
        private readonly RecebimentoService _recebimentoService;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        private readonly PoupancaService _poupancaService;
        private readonly CategoriaService _categoriaService;
        private readonly CartaoService _cartaoService;
        #endregion

        #region Construtor
        public RelatorioController(PoupancaService poupancaService, UsuarioService usuarioService, LancamentoService lancamentoService, RecebimentoService recebimentoService,
            UsuarioAutenticado usuarioAutenticado, CategoriaService categoriaService, CartaoService cartaoService)
        {
            _usuarioService = usuarioService;
            _lancamentoService = lancamentoService;
            _recebimentoService = recebimentoService;
            _poupancaService = poupancaService;
            _usuarioAutenticado = usuarioAutenticado;
            _categoriaService = categoriaService;
            _cartaoService = cartaoService;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Hoje
        public IActionResult Hoje()
        {
            #region Cálculos
            ViewBag.CalculoRecebimentos = _recebimentoService.CalculoDiaAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoLancamentos = _lancamentoService.CalculoDiaAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoDepositos = _poupancaService.CalculoDiaAtual(_usuarioAutenticado.IdUsuario(User));
            #endregion

            #region Listas
            ViewBag.Recebimentos = _recebimentoService.ListarDia(_usuarioAutenticado.IdUsuario(User));
            ViewBag.Lancamentos = _lancamentoService.ListarDia(_usuarioAutenticado.IdUsuario(User));
            ViewBag.Depositos = _poupancaService.ListarDia(_usuarioAutenticado.IdUsuario(User));
            #endregion

            #region Categoria e Cartão do Lançamento
            foreach (var item in ViewBag.Lancamentos)
            {
                ViewBag.Categoria = _categoriaService.Obter(item.Categoria.IdCategoria).Titulo;
                ViewBag.Cartao = _cartaoService.Obter(item.Cartao.IdCartao).Banco;
            }
            #endregion

            #region Banco da Poupança
            foreach (var item in ViewBag.Depositos)
            {
                ViewBag.BancoPoupanca = _cartaoService.Obter(item.Cartao.IdCartao).Banco;
            }
            #endregion

            return View();
        }
        #endregion

        #region MesAtual
        public IActionResult MesAtual()
        {
            return View();
        }
        #endregion

        #region Quinzenal
        public IActionResult Quinzenal()
        {
            return View();
        }
        #endregion

        #region MesPassado 
        public IActionResult MesPassado()
        {
            return View();
        }
        #endregion
    }
}