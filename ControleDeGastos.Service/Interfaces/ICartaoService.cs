using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Services.Interfaces
{
    public interface ICartaoService<T>
    {
        bool Cadastrar(Cartao c, Usuario usuario);
        bool Excluir(Cartao c);
        List<Cartao> Listar(int idusuario);
        Cartao ObterCartaoPorId(int idCartao);
    }
}
