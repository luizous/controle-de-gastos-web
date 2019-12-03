using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using ControleDeGastos.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Web.Controllers
{
    [Authorize]
    public class MetaController : Controller
    {
        #region Atributos
        private readonly MetaService _metaService;
        private readonly UsuarioService _usuarioService;
        private readonly UsuarioAutenticado _usuarioAutenticado;
        #endregion

        #region Construtor
        public MetaController(MetaService metaService, UsuarioService usuarioService,
            UsuarioAutenticado usuarioAutenticado)
        {
            _metaService = metaService;
            _usuarioService = usuarioService;
            _usuarioAutenticado = usuarioAutenticado;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.Metas = _metaService.Listar(_usuarioAutenticado.IdUsuario(User));
            return View();
        }
        #endregion

        #region Cadastrar
        public IActionResult Cadastrar(Meta m)
        {
            if (ModelState.IsValid)
            {
                _metaService.Cadastrar(m, _usuarioAutenticado.IdUsuario(User));
                return RedirectToAction("Index", m);
            }
            return View("Index", m);
        }
        #endregion

        #region Remover
        public IActionResult Remover(int? idMeta)
        {
            if (idMeta != null)
            {
                _metaService.Remover(idMeta);
            }
            return RedirectToAction("Perfil", "Usuario");
        }
        #endregion

        #region Conquistada
        public IActionResult Conquistada(int? idMeta)
        {
            if (idMeta != null)
            {
                _metaService.Conquistada(idMeta);
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