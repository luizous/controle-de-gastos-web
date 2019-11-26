using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface ICategoriaRepository<T>
    {
        bool Cadastrar(Categoria ca, Usuario usuario);
        bool Remover(Categoria ca);
        List<Categoria> ListarPorUsuario(int idUsuario);
        Categoria Obter(int? idCategoria);
    }
}
