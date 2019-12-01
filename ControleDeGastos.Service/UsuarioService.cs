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

        #region Cadastrar
        public bool Cadastrar(Usuario u)
        {
            return _usuarioRepository.Cadastrar(u);
        }
        #endregion

        #region GetUsuarioLogado
        public Usuario GetUsuarioLogado()
        {
            return _usuarioRepository.GetUsuarioLogado();
        }
        #endregion

        #region BuscarPorCpf
        public Usuario BuscarPorCpf(Usuario u)
        {
            return _usuarioRepository.BuscarPorCpf(u);
        }
        #endregion

        #region BuscarPorLogin
        public Usuario BuscarPorLogin(Usuario u)
        {
            return _usuarioRepository.BuscarPorLogin(u);
        }
        #endregion

        #region Listar
        public List<Usuario> ListarUsuarios()
        {
            return _usuarioRepository.ListarUsuarios();
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

        #region Editar
        public bool Editar(Usuario u)
        {
            return _usuarioRepository.Editar(u);
        }
        #endregion
    }
}
