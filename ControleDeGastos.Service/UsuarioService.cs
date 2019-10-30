using ControleDeGastos.Repository.Interfaces;
using ControleDeGastos.Services.Interfaces;

namespace ControleDeGastos.Services
{
    public class UsuarioService : IUsuarioService
    {
        #region Atributos
        private readonly IUsuarioRepository _usuarioRepository;
        #endregion

        #region Construtor
        UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        #endregion
    }
}
