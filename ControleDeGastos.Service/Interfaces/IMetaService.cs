using ControleDeGastos.Domain;
using System.Collections.Generic;

namespace ControleDeGastos.Service.Interfaces
{
    public interface IMetaService<T>
    {
        bool Cadastrar(Meta m, int idUsuario);
        bool Conquistada(int? idMeta);
        bool Remover(int? idMeta);
        List<Meta> Listar(int idUsuario);
        Meta Obter(int? idMeta);
    }
}
