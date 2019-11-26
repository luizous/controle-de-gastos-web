using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Service.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class CategoriaService : ICategoriaService<Categoria>
    {
        #region Atributos
        private readonly CategoriaRepository _categoriaRepository;
        #endregion

        #region Construtor
        public CategoriaService(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Categoria ca, Usuario usuario)
        {
            return _categoriaRepository.Cadastrar(ca, usuario);
        }
        #endregion

        #region Remover
        public bool Remover(int? idCategoria)
        {
            var categoria = Obter(idCategoria);
            return _categoriaRepository.Remover(categoria);
        }
        #endregion

        #region ListarPorUsuario
        public List<Categoria> ListarPorUsuario(int idUsuario)
        {
            return _categoriaRepository.ListarPorUsuario(idUsuario);
        }
        #endregion

        #region Obter
        public Categoria Obter(int? idCategoria)
        {
            return _categoriaRepository.Obter(idCategoria);
        }
        #endregion
    }
}
