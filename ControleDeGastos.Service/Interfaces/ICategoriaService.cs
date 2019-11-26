using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Service.Interfaces
{
    public interface ICategoriaService<T>
    {
        bool Cadastrar(Categoria ca, Usuario usuario);
        bool Remover(int? idCategoria);
        List<Categoria> ListarPorUsuario(int idUsuario);
        Categoria Obter(int? idCategoria);
    }
}
