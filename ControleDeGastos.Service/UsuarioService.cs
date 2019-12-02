using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class UsuarioService : IUsuarioService<Usuario>
    {
        #region Atributos
        private readonly UsuarioRepository _usuarioRepository;
        #endregion

        #region Construtor
        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        #endregion

        #region CadastrarOuEditar
        public bool CadastrarOuEditar(Usuario u)
        {
            try
            {
                return _usuarioRepository.CadastrarOuEditar(u);
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Obter
        public Usuario Obter(int idUsuario)
        {
            return _usuarioRepository.Obter(idUsuario);
        }
        #endregion

        #region ObterPorToken
        public Usuario ObterPorToken(Guid token)
        {
            return _usuarioRepository.ObterPorToken(token);
        }
        #endregion
    }
}
