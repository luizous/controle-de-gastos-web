using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ControleDeGastos.Web.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
        #region Atributos
        private readonly UsuarioService _usuarioService;
        private readonly LancamentoService _lancamentoService;
        private readonly RecebimentoService _recebimentoService;
        private readonly PoupancaService _poupancaService;
        private readonly CategoriaService _categoriaService;
        private readonly CartaoService _cartaoService;
        private readonly MetaService _metaService;
        private readonly UserManager<UsuarioLogado> _userManager;
        private readonly SignInManager<UsuarioLogado> _signInManager;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public UsuarioController(CategoriaService categoriaService, CartaoService cartaoService, MetaService metaService, PoupancaService poupancaService,
            UsuarioService usuarioService, LancamentoService lancamentoService, RecebimentoService recebimentoService,
            UserManager<UsuarioLogado> userManager, SignInManager<UsuarioLogado> signInManager, UsuarioAutenticado usuarioAutenticado)
        {
            _usuarioService = usuarioService;
            _lancamentoService = lancamentoService;
            _recebimentoService = recebimentoService;
            _categoriaService = categoriaService;
            _cartaoService = cartaoService;
            _metaService = metaService;
            _poupancaService = poupancaService;
            _userManager = userManager;
            _signInManager = signInManager;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Index
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Usuario u)
        {
            if (u.Email != null && u.Senha != null)
            {
                var result = await _signInManager.PasswordSignInAsync(u.Email, u.Senha, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Dashboard", "Usuario");
                }
                ModelState.AddModelError("", "E-mail ou senha incorretos! Tente novamente.");
            }
            ModelState.AddModelError("", "E-mail ou senha incorretos! Tente novamente.");
            return View(u);
        }
        #endregion

        #region Cadastro
        [AllowAnonymous]
        public IActionResult Cadastro()
        {
            return View();
        }
        #endregion

        #region Cadastro
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Cadastro(Usuario u)
        {
            if (ModelState.IsValid)
            {
                UsuarioLogado usuarioLogado = new UsuarioLogado
                {
                    Email = u.Email,
                    UserName = u.Login
                };
                IdentityResult result = await _userManager.CreateAsync(usuarioLogado, u.Senha);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(usuarioLogado, isPersistent: false);
                    u.Token = Guid.Parse(usuarioLogado.Id);
                    if (_usuarioService.CadastrarOuEditar(u))
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError("", "Este e-mail já está sendo utilizado!");
                }
            }
            ModelState.AddModelError("", "Erro ao cadastrar usuário. Tente novamente.");
            return View(u);
        }
        #endregion

        #region Editar
        [HttpPost]
        public async Task<IActionResult> Editar(Usuario u)
        {
            if (_usuarioService.CadastrarOuEditar(u))
            {
                return RedirectToAction("Perfil");
            }
            ModelState.AddModelError("", "Este e-mail já está sendo utilizado!");

            ViewBag.Metas = _metaService.Listar(_usuarioAutenticado.IdUsuario(User));
            ViewBag.Categorias = _categoriaService.ListarPorUsuario(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoPoupanca = _poupancaService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoLancamento = _lancamentoService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoRecebimento = _recebimentoService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            return View("Perfil", u);
        }
        #endregion

        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Usuario");
        }
        #endregion

        #region Dashboard
        public IActionResult Dashboard()
        {
            #region Cálculos
            ViewBag.CalculoRecebimentos = _recebimentoService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoLancamentos = _lancamentoService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoDepositos = _poupancaService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            #endregion

            #region Listas
            ViewBag.Lancamentos = _lancamentoService.ListarRecentes(_usuarioAutenticado.IdUsuario(User));
            ViewBag.Recebimentos = _recebimentoService.ListarRecentes(_usuarioAutenticado.IdUsuario(User));
            foreach (var item in ViewBag.Lancamentos)
            {
                ViewBag.Categoria = _categoriaService.Obter(item.Categoria.IdCategoria).Titulo;
                ViewBag.Cartao = _cartaoService.Obter(item.Cartao.IdCartao).Banco;
            }
            #endregion

            ViewBag.Artigos = NewsAPIHelper.GetNews();

            return View();
        }
        #endregion

        #region Perfil
        public IActionResult Perfil()
        {
            ViewBag.Metas = _metaService.Listar(_usuarioAutenticado.IdUsuario(User));
            ViewBag.Categorias = _categoriaService.ListarPorUsuario(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoPoupanca = _poupancaService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoLancamento = _lancamentoService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));
            ViewBag.CalculoRecebimento = _recebimentoService.CalculoMesAtual(_usuarioAutenticado.IdUsuario(User));

            return View(_usuarioService.Obter(_usuarioAutenticado.IdUsuario(User)));
        }
        #endregion
    }
}