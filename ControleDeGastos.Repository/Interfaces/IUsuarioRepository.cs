using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface IUsuarioRepository<T>
    {
        bool Cadastrar(Usuario u);
        Usuario GetUsuarioLogado();
        Usuario BuscarPorCpf(Usuario u);
        Usuario BuscarPorLogin(Usuario u);
        bool Logar(string email, string senha);
        List<Usuario> ListarUsuarios();
        bool Editar(Usuario u);
        Usuario Obter(int idUsuario);
        Usuario ObterPorToken(Guid token);
    }
}
