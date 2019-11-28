using ControleDeGastos.Domain;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Api.Controllers
{
    [Route("api/meta")]
    [ApiController]
    public class MetaApiController : ControllerBase
    {
        #region Atributos
        private readonly UsuarioService _usuarioService;
        private readonly MetaService _metaService;
        #endregion

        #region Construtor
        public MetaApiController(UsuarioService usuarioService,
            MetaService metaService)
        {
            _usuarioService = usuarioService;
            _metaService = metaService;
        }
        #endregion

        #region Listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(_metaService.Listar(1));
        }
        #endregion

        #region Cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody]Meta m)
        {
            if (ModelState.IsValid)
            {
                if (_metaService.Cadastrar(m, 1))
                {
                    return Created("", m);
                }
                return Conflict(new { msg = "Erro ao cadastrar meta." });
            }
            return BadRequest(ModelState);
        }
        #endregion

        #region Remover
        [HttpDelete]
        [Route("remover/{idMeta}")]
        public IActionResult Remover(int? idMeta)
        {
            if (idMeta == null)
               return BadRequest("Não foi possível remover esta Meta.");

            if(_metaService.Remover(idMeta) == false)
            {
                return BadRequest("Não foi possível remover esta Meta.");
            }
            return Ok();
        }
        #endregion
    }
}