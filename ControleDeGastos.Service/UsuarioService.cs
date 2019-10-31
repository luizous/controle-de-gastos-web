using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using ControleDeGastos.Services.Interfaces;

namespace ControleDeGastos.Services
{
    public class UsuarioService : IUsuarioService<Usuario>
    {
        #region Atributos
        private readonly IUsuarioRepository<Usuario> _usuarioRepository;
        #endregion

        #region Construtor
        UsuarioService(IUsuarioRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        #endregion
    }
}
