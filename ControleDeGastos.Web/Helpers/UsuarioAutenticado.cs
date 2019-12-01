using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace ControleDeGastos.Web.Helpers
{
    public class UsuarioAutenticado : Controller
    {
        private readonly UsuarioService _usuarioService;
        private readonly UserManager<UsuarioLogado> _userManager;

        public UsuarioAutenticado(UsuarioService usuarioService, UserManager<UsuarioLogado> userManager)
        {
            _usuarioService = usuarioService;
            _userManager = userManager;
        }

        public Usuario Usuario(ClaimsPrincipal user)
        { 
            return _usuarioService.ObterPorToken(Guid.Parse(_userManager.GetUserId(user)));
        }

        public int IdUsuario(ClaimsPrincipal user)
        {
            var usuario = _usuarioService.ObterPorToken(Guid.Parse(_userManager.GetUserId(user)));
            return usuario.IdUsuario;
        }
    }
}
