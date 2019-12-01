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
        List<Poupanca> ListarMesAtual(int idUsuario);
        List<Poupanca> ListarDia(int idUsuario);
        List<Poupanca> ListarMesPassado(int idUsuario);
        List<Poupanca> ListarQuinzenal(int idUsuario);
    }
}
