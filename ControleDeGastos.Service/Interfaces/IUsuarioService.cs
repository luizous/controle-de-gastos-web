using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;

namespace ControleDeGastos.Service.Interfaces
{
    public interface IUsuarioService<T>
    {
        bool CadastrarOuEditar(Usuario u);
        Usuario Obter(int idUsuario);
        Usuario ObterPorToken(Guid token);
    }
}
