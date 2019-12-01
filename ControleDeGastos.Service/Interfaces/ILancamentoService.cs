using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Service.Interfaces
{
    public interface ILancamentoService<T>
    {
        bool Cadastrar(Lancamento r, Usuario usuario);
        bool Editar(Lancamento r);
        Lancamento Obter(int? idLancamento);
        double CalculoDiaAtual(int idUsuario);
        double CalculoMesAtual(int idUsuario);
        double CalculoMesPassado(int idUsuario);
        double CalculoQuinzenal(int idUsuario);
        double CalculoPorCategoria(int idUsuario, int idCategoria);
        List<Lancamento> ListarRecentes(int idUsuario);
        List<Lancamento> ListarPorCategoria(int idUsuario, int idCategoria);
        List<Lancamento> ListarDia(int idUsuario);
        List<Lancamento> ListarMesAtual(int idUsuario);
        List<Lancamento> ListarMesPassado(int idUsuario);
        List<Lancamento> ListarQuinzenal(int idUsuario);
    }
}
