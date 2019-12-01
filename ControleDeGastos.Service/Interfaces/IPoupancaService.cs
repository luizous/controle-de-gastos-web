using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeGastos.Service.Interfaces
{
    public interface IPoupancaService<T>
    {

        bool Cadastrar(Poupanca p, Usuario usuario);
        bool Editar(Poupanca p);
        Poupanca Obter(int? idPoupanca);
        List<Poupanca> Listar(int idUsuario);
        double CalculoMesAtual(int idUsuario);
        double CalculoDiaAtual(int idUsuario);
        double CalculoMesPassado(int idUsuario);
        double CalculoQuinzenal(int idUsuario);
        List<Poupanca> ListarDia(int idUsuario);
        List<Poupanca> ListarMesAtual(int idUsuario);
        List<Poupanca> ListarMesPassado(int idUsuario);
        List<Poupanca> ListarQuinzenal(int idUsuario);
    }
}
