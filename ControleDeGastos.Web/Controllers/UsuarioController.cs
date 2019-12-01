using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ControleDeGastos.Web.Controllers
{
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
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }
        #endregion

        #region CadastrarOuEditar
        [HttpPost]
        public async Task<IActionResult> CadastrarOuEditar(Usuario u)
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
                AdicionarErros(result);
            }
            return View(u);
        }
        #endregion

        #region Login
        [HttpPost]
        public async Task<IActionResult> Login(Usuario u)
        {
            var result = await _signInManager.PasswordSignInAsync(u.Email, u.Senha, true, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Dashboard", "Usuario");
            }
            ModelState.AddModelError("", "Falha no Login");
            return View();
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

        #region AdicionarErros
        private void AdicionarErros(IdentityResult result)
        {
            foreach (var erro in result.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }
        #endregion
    }
}