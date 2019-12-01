using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.Repository
{
    public class UsuarioRepository : IUsuarioRepository<Usuario>
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        public UsuarioRepository(Context context)
        {
            _context = context;
        }
        #endregion

        #region Cadastrar
        public bool CadastrarOuEditar(Usuario u)
        {
            if (u.IdUsuario > 0)
            {
                // editar
                _context.Entry(u).State = EntityState.Modified;
                _context.SaveChanges();
            }
            else
            {
                _context.Usuarios.Add(u);
                _context.SaveChanges();
            }
            return true;
        }
        #endregion

        #region Obter
        public Usuario Obter(int idUsuario) => _context.Usuarios.FirstOrDefault(x => x.IdUsuario == idUsuario);
        #endregion

        #region ObterPorToken
        public Usuario ObterPorToken(Guid token) => _context.Usuarios.FirstOrDefault(x => x.Token == token);
        #endregion

        #region Validar
        public Usuario Validar(Usuario u)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Login.Equals(u.Login) ||
                                                         x.Cpf.Equals(u.Cpf) ||
                                                         x.Email.Equals(u.Email));
        }
        #endregion
    }
}
