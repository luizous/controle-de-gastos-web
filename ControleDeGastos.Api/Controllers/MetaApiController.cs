using ControleDeGastos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Api.Controllers
{
    [Route("api/meta")]
    [ApiController]
    public class MetaApiController : ControllerBase
    {
        #region Atributos
        private readonly MetaRepository _metaRepository;
        #endregion

        #region Construtor
        public MetaApiController(MetaRepository metaRepository)
        {
            _metaRepository = metaRepository;
        }
        #endregion

        #region Listar
        // Rota: /api/meta/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(/*_metaRepository.Listar(1)*/);
        }
        #endregion
    }
}