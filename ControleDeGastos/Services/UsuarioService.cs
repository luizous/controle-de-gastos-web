using ControleDeGastos.DAL.Interfaces;
using ControleDeGastos.Services.Interfaces;

namespace ControleDeGastos.Services
{
    public class UsuarioService : IUsuarioService
    {
        #region Atributos
        private readonly IUsuarioDAO _usuarioDAO;
        #endregion

        #region Construtor
        UsuarioService(IUsuarioDAO usuarioDAO)
        {
            _usuarioDAO = usuarioDAO;
        }
        #endregion
    }
}
