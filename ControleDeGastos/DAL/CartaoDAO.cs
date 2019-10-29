using ControleDeGastos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.DAL
{
    public class CartaoDAO
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        public CartaoDAO(Context context) 
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

        #region Excluir
        public bool Excluir(Cartao c)
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

        #region ObterCartaoPorId
        public Cartao ObterCartaoPorId(int idCartao)
        {
            return _context.Cartoes.FirstOrDefault(x => x.IdCartao == idCartao);
        }
        #endregion
    }
}
