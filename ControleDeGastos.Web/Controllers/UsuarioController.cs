using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ControleDeGastos.Web.Controllers
{
    public class UsuarioController : Controller
    {
        #region Atributos
        private readonly UsuarioService _usuarioService;
        private readonly LancamentoService _lancamentoService;
        private readonly RecebimentoService _recebimentoService;
        private readonly UserManager<UsuarioLogado> _userManager;
        private readonly SignInManager<UsuarioLogado> _signInManager;
        #endregion

        #region Construtor
        public UsuarioController(UsuarioService usuarioService, LancamentoService lancamentoService, RecebimentoService recebimentoService,
            UserManager<UsuarioLogado> userManager, SignInManager<UsuarioLogado> signInManager)
        {
            _usuarioService = usuarioService;
            _lancamentoService = lancamentoService;
            _recebimentoService = recebimentoService;
            _userManager = userManager;
            _signInManager = signInManager;
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

        #region Cadastrar
        [HttpPost]
        public async Task<IActionResult> Cadastrar(Usuario u)
        {
            if (ModelState.IsValid)
            {
                UsuarioLogado usuarioLogado = new UsuarioLogado
                {
                    Email = u.Email,
                    UserName = u.Email
                };
                IdentityResult result = await _userManager.CreateAsync(usuarioLogado, u.Senha);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(usuarioLogado, isPersistent: false);
                    u.Token = Guid.Parse(usuarioLogado.Id);
                    if (_usuarioService.Cadastrar(u))
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
            var u = _usuarioService.ObterPorToken(Guid.Parse(_userManager.GetUserId(User)));
            ViewBag.Lancamentos = _lancamentoService.Listar(u.IdUsuario);
            ViewBag.Recebimentos = _recebimentoService.Listar(u.IdUsuario);
            return View();
        }
        #endregion

        #region Perfil
        public IActionResult Perfil()
        {
            return View();
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