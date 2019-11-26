using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Service.Interfaces
{
    public interface ICartaoService<T>
    {
        bool Cadastrar(Cartao c, Usuario usuario);
        bool Remover(int? idCartao);
        List<Cartao> Listar(int idusuario);
        Cartao Obter(int? idCartao);
    }
}
