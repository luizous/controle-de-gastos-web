using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface IPoupancaRepository<T>
    {
        bool Cadastrar(Poupanca p, Usuario usuario);
        bool Editar(Poupanca p);
        List<Poupanca> Listar(int idUsuario);
        Poupanca Obter(int? idRecebimento);
    }
}
