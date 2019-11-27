using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;

namespace ControleDeGastos.Service.Interfaces
{
    public interface IUsuarioService<T>
    {
        bool Cadastrar(Usuario u);
        Usuario GetUsuarioLogado();
        Usuario BuscarPorCpf(Usuario u);
        Usuario BuscarPorLogin(Usuario u);
        bool Logar(string email, string senha);
        List<Usuario> ListarUsuarios();
        Usuario Obter(int idUsuario);
        Usuario ObterPorToken(Guid token);
        bool Editar(Usuario u);
    }
}
