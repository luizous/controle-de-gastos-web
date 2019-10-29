using ControleDeGastos.Models;
using System.Collections.Generic;

namespace ControleDeGastos.DAL.Interfaces
{
    public interface IRecebimentoDAO
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
