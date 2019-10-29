using ControleDeGastos.DAL.Interfaces;
using ControleDeGastos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.DAL
{
    public class RecebimentoDAO : IRecebimentoDAO
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        private RecebimentoDAO(Context context) 
        {
            _context = context;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Recebimento r, Usuario usuario)
        {
            try
            {
                r.Usuario = usuario;
                _context.Recebimentos.Add(r);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Editar
        public bool Editar(Recebimento r)
        {
            try
            {
                _context.Entry(r).State = EntityState.Modified;
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
        public List<Recebimento> Listar(int idUsuario) => _context.Recebimentos
            .Where(x => x.Usuario.IdUsuario == idUsuario)
            .ToList();
        #endregion

        #region ListarRecentes
        public List<Recebimento> ListarRecentes(int idUsuario) => _context.Recebimentos
            .Where(x => x.Usuario.IdUsuario == idUsuario)
            .Take(10) // pega os últimos 10 registros
            .ToList();
        #endregion

        #region ObterRecebimentoPorId
        public Recebimento ObterRecebimentoPorId(int idRecebimento)
        {
            return _context.Recebimentos.FirstOrDefault(x => x.IdRecebimento == idRecebimento);
        }
        #endregion

        #region ListarLancamentoDia
        public List<Recebimento> ListarRecebimentoDia(int idUsuario) => _context.Recebimentos
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataRecebimento.Day == DateTime.Now.Day).ToList();
        #endregion

        #region ListarRecebimentoMesAtual
        public List<Recebimento> ListarRecebimentoMesAtual(int idUsuario) => _context.Recebimentos
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataRecebimento.Month == DateTime.Now.Month)
            .ToList();
        #endregion

        #region ListarRecebimentoMesPassado
        public List<Recebimento> ListarRecebimentoMesPassado(int idUsuario)
        {
            var mesPassado = DateTime.Now.AddMonths(-1).Month;
            return _context.Recebimentos
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataRecebimento.Month.Equals(mesPassado))
            .ToList();
        }
        #endregion

        #region ListarRecebimentoQuinzenal
        public List<Recebimento> ListarRecebimentoQuinzenal(int idUsuario)
        {
            var quinzenal = DateTime.Now.Subtract(TimeSpan.FromDays(15));
            return _context.Recebimentos
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataRecebimento >= quinzenal &&
                        x.DataRecebimento < DateTime.Now)
            .ToList();
        }
        #endregion
    }
}
