using ControleDeGastos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Api.Controllers
{
    [Route("api/categoria")]
    [ApiController]
    public class CategoriaApiController : ControllerBase
    {
        #region Atributos
        private readonly CategoriaRepository _categoriaRepository;
        #endregion

        #region Construtor
        public CategoriaApiController(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        #endregion

        #region Listar
        // Rota: /api/categoria/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            var teste = _categoriaRepository.ListarPorUsuario(1);
            return Ok(_categoriaRepository.ListarPorUsuario(1));
        }
        #endregion
    }
}