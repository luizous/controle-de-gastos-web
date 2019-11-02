using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Services.Interfaces
{
    public interface IUsuarioService<T>
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
