using ControleDeGastos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Services.Interfaces
{
    public interface ICategoriaService<T>
    {
        bool Cadastrar(Categoria ca, Usuario usuario);
        bool Excluir(Categoria ca);
        List<Categoria> ListarPorUsuario(int idUsuario);
        Categoria ObterCategoriaPorId(int idCategoria);
    }
}
