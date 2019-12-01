using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface IRecebimentoRepository<T>
    {
        bool Cadastrar(Recebimento r, Usuario usuario);
        bool Editar(Recebimento r);
        List<Recebimento> Listar(int idUsuario);
        Recebimento Obter(int? idRecebimento);
        List<Recebimento> ListarRecentes(int idUsuario);
        List<Recebimento> ListarDia(int idUsuario);
        List<Recebimento> ListarMesAtual(int idUsuario);
        List<Recebimento> ListarMesPassado(int idUsuario);
        List<Recebimento> ListarQuinzenal(int idUsuario);
    }
}
