using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeGastos.Service.Interfaces
{
    public interface IPoupancaService<T>
    {

        bool Cadastrar(Poupanca p, Usuario usuario);
        bool Editar(Poupanca p);
        Poupanca Obter(int? idPoupanca);
        List<Poupanca> Listar(int idUsuario);
    }
}
