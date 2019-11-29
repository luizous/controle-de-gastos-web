using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.Repository
{
    public class CategoriaRepository : ICategoriaRepository<Categoria>
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        public CategoriaRepository(Context context) 
        {
            _context = context;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Categoria ca, Usuario usuario)
        {
            try
            {
                ca.Usuario = usuario;
                _context.Categorias.Add(ca);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region Remover
        public bool Remover(Categoria ca)
        {
            try
            {
                _context.Categorias.Remove(ca);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region ListarPorUsuario
        public List<Categoria> ListarPorUsuario(int idUsuario)
        {
            return _context.Categorias.Where(x => x.Usuario.IdUsuario == idUsuario).ToList();
        }
        #endregion

        #region Obter
        public Categoria Obter(int? idCategoria)
        {
            return _context.Categorias.Find(idCategoria);
        }
        #endregion
    }
}
