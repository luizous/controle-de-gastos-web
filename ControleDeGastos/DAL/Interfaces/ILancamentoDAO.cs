using ControleDeGastos.Models;
using System.Collections.Generic;

namespace ControleDeGastos.DAL.Interfaces
{
    public interface ILancamentoDAO
    {
        bool Cadastrar(Lancamento r, Usuario usuario);
        bool Editar(Lancamento r);
        List<Lancamento> Listar(int idUsuario);
        List<Lancamento> ListarRecentes(int idUsuario);
        List<Lancamento> ListarLancamentoDia(int idUsuario);
        List<Lancamento> ListarLancamentoMesAtual(int idUsuario);
        List<Lancamento> ListarLancamentoMesPassado(int idUsuario);
        List<Lancamento> ListarLancamentoQuinzenal(int idUsuario);
        List<Lancamento> ListarPorCategoria(int idUsuario, int idCategoria);
    }
}
