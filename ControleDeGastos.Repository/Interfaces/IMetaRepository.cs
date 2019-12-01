using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Repository.Interfaces
{
    public interface IMetaRepository<T>
    {
        List<Meta> Listar(int idUsuario);
        bool Remover(Meta m);
        bool Conquistada(Meta m);
    }
}
