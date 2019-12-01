using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.Repository
{
    public class PoupancaRepository : IPoupancaRepository<Poupanca>
    {
        #region Atributos
        private readonly Context _context;
        #endregion

        #region Construtor
        public PoupancaRepository(Context context)
        {
            _context = context;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Poupanca p, Usuario usuario)
        {
            try
            {
                p.Usuario = usuario;
                _context.Poupancas.Add(p);
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
        public bool Editar(Poupanca p)
        {
            try
            {
                _context.Poupancas.Update(p);
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
        public List<Poupanca> Listar(int idUsuario) => _context.Poupancas
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario)
            .ToList();
        #endregion

        #region Obter
        public Poupanca Obter(int? idPoupanca)
        {
            return _context.Poupancas.Find(idPoupanca);
        }
        #endregion

        #region ListarMesAtual
        public List<Poupanca> ListarMesAtual(int idUsuario) => _context.Poupancas
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataDeposito.Month == DateTime.Now.Month)
            .ToList();
        #endregion

        #region ListarDia
        public List<Poupanca> ListarDia(int idUsuario) => _context.Poupancas
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataDeposito.Day == DateTime.Now.Day).ToList();
        #endregion

        #region ListarLancamentoMesPassado
        public List<Poupanca> ListarMesPassado(int idUsuario)
        {
            var mesPassado = DateTime.Now.AddMonths(-1).Month;
            var lista = _context.Poupancas
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataDeposito.Month.Equals(mesPassado))
            .ToList();
            return lista;
        }
        #endregion

        #region ListarQuinzenal
        public List<Poupanca> ListarQuinzenal(int idUsuario)
        {
            var quinzenal = DateTime.Now.Subtract(TimeSpan.FromDays(15));
            var lista = _context.Poupancas
            .Include("Cartao")
            .Where(x => x.Usuario.IdUsuario == idUsuario &&
                        x.DataDeposito >= quinzenal &&
                        x.DataDeposito < DateTime.Now)
            .ToList();
            return lista;
        }
        #endregion
    }
}
