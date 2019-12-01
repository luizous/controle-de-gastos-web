using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.Repository
{
    public class MetaRepository : IMetaRepository<Meta>
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        public MetaRepository(Context context)
        {
            _context = context;
        }
        #endregion

        #region Listar
        public List<Meta> Listar(int idUsuario)
        {
            return _context.Metas.Where(x => x.Usuario.IdUsuario == idUsuario).OrderBy(y => y.DataFinal).ToList();
        }
        #endregion

        #region Conquistada
        public bool Conquistada(Meta m)
        {
            try
            {
                _context.Metas.Update(m);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Remover
        public bool Remover(Meta m)
        {
            try
            {
                _context.Metas.Remove(m);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Meta m, Usuario usuario)
        {
            try
            {
                m.Usuario = usuario;
                _context.Metas.Add(m);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region Obter
        public Meta Obter(int? idMeta)
        {
            return _context.Metas.Find(idMeta);
        }
        #endregion
    }
}
