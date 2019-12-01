using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface ILancamentoRepository<T>
    {
        bool Cadastrar(Lancamento r, Usuario usuario);
        bool Editar(Lancamento r);
        Lancamento Obter(int? idLancamento);
        List<Lancamento> Listar(int idUsuario);
        List<Lancamento> ListarRecentes(int idUsuario);
        List<Lancamento> ListarDia(int idUsuario);
        List<Lancamento> ListarMesAtual(int idUsuario);
        List<Lancamento> ListarMesPassado(int idUsuario);
        List<Lancamento> ListarQuinzenal(int idUsuario);
        List<Lancamento> ListarPorCategoria(int idUsuario, int idCategoria);
    }
}
