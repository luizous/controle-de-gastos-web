using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeGastos.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Api.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioApiController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioApiController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}