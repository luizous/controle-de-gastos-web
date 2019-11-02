using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface ICartaoRepository<T>
    {
        bool Cadastrar(Cartao c, Usuario usuario);
        bool Excluir(Cartao c);
        List<Cartao> Listar(int idusuario);
        Cartao ObterCartaoPorId(int idCartao);
    }
}
