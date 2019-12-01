using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface IUsuarioRepository<T>
    {
        bool CadastrarOuEditar(Usuario u);
        Usuario Obter(int idUsuario);
        Usuario ObterPorToken(Guid token);
    }
}
