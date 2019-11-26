using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Service.Interfaces
{
    public interface IRecebimentoService<T>
    {
        bool Cadastrar(Recebimento r, Usuario usuario);
        bool Editar(Recebimento r);
        List<Recebimento> Listar(int idUsuario);
        Recebimento Obter(int? idRecebimento);
        double CalculoDiaAtual(int idUsuario);
        double CalculoMesAtual(int idUsuario);
        double CalculoMesPassado(int idUsuario);
        double CalculoQuinzenal(int idUsuario);
    }
}
