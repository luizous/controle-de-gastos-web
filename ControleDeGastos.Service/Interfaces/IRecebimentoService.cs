using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Service.Interfaces
{
    public interface IRecebimentoService<T>
    {
        bool Cadastrar(Recebimento r, Usuario usuario);
        bool Editar(Recebimento r);
        List<Recebimento> Listar(int idUsuario);
        List<Recebimento> ListarRecentes(int idUsuario);
        Recebimento Obter(int? idRecebimento);
        double CalculoDiaAtual(int idUsuario);
        double CalculoMesAtual(int idUsuario);
        double CalculoMesPassado(int idUsuario);
        double CalculoQuinzenal(int idUsuario);
        List<Recebimento> ListarDia(int idUsuario);
        List<Recebimento> ListarMesAtual(int idUsuario);
        List<Recebimento> ListarMesPassado(int idUsuario);
        List<Recebimento> ListarQuinzenal(int idUsuario);
    }
}
