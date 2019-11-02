using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Services.Interfaces
{
    public interface ILancamentoService<T>
    {
        bool Cadastrar(Lancamento r, Usuario usuario);
        bool Editar(Lancamento r);
        double CalculoDiaAtual(int idUsuario);
        double CalculoMesAtual(int idUsuario);
        double CalculoMesPassado(int idUsuario);
        double CalculoQuinzenal(int idUsuario);
        double CalculoPorCategoria(int idUsuario, int idCategoria);
    }
}
