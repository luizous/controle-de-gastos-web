using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Services.Interfaces
{
    public interface IRecebimentoService<T>
    {
        bool Cadastrar(Recebimento r, Usuario usuario);
        bool Editar(Recebimento r);
        double CalculoDiaAtual(int idUsuario);
        double CalculoMesAtual(int idUsuario);
        double CalculoMesPassado(int idUsuario);
        double CalculoQuinzenal(int idUsuario);
    }
}
