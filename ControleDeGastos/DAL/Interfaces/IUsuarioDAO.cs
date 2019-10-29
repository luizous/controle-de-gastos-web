using ControleDeGastos.Models;
using System.Collections.Generic;

namespace ControleDeGastos.DAL.Interfaces
{
    public interface IUsuarioDAO
    {
        bool Cadastrar(Usuario u);
        Usuario GetUsuarioLogado();
        Usuario BuscarPorCpf(Usuario u);
        Usuario BuscarPorLogin(Usuario u);
        bool Logar(string email, string senha);
        List<Usuario> ListarUsuarios();
        bool Editar(Usuario u);
    }
}
