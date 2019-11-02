using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using ControleDeGastos.Services.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class CategoriaService : ICategoriaService<Categoria>
    {
        #region Atributos
        private readonly ICategoriaRepository<Categoria> _categoriaRepository;
        #endregion

        #region Construtor
        public CategoriaService(ICategoriaRepository<Categoria> categoriaRepository)
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

        #region Excluir
        public bool Excluir(Categoria ca)
        {
            return _categoriaRepository.Excluir(ca);
        }
        #endregion

        #region ListarPorUsuario
        public List<Categoria> ListarPorUsuario(int idUsuario)
        {
            return _categoriaRepository.ListarPorUsuario(idUsuario);
        }
        #endregion

        #region ObterCategoriaPorId
        public Categoria ObterCategoriaPorId(int idCategoria)
        {
            return _categoriaRepository.ObterCategoriaPorId(idCategoria);
        }
        #endregion
    }
}
