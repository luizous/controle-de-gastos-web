using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface IRecebimentoRepository<T>
    {
        bool Cadastrar(Recebimento r, Usuario usuario);
        bool Editar(Recebimento r);
        List<Recebimento> Listar(int idUsuario);
        List<Recebimento> ListarRecentes(int idUsuario);
        List<Recebimento> ListarRecebimentoDia(int idUsuario);
        List<Recebimento> ListarRecebimentoMesAtual(int idUsuario);
        List<Recebimento> ListarRecebimentoMesPassado(int idUsuario);
        List<Recebimento> ListarRecebimentoQuinzenal(int idUsuario);
    }
}
