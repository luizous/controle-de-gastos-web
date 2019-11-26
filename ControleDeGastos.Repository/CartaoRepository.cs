using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.Repository
{
    public class CartaoRepository : ICartaoRepository<Cartao>
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        public CartaoRepository(Context context) 
        {
            _context = context;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Cartao c, Usuario usuario)
        {
            try
            {
                c.Usuario = usuario;
                _context.Cartoes.Add(c);
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
        public bool Remover(Cartao c)
        {
            try
            {
                _context.Cartoes.Remove(c);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Listar
        public List<Cartao> Listar(int idusuario) => _context.Cartoes
            .Where(x => x.Usuario.IdUsuario == idusuario)
            .ToList();
        #endregion

        #region Obter
        public Cartao Obter(int? idCartao)
        {
            return _context.Cartoes.Find(idCartao);
        }
        #endregion
    }
}
