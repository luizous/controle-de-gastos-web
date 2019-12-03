using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Service.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class PoupancaService : IPoupancaService<Poupanca>
    {
        #region Atributos
        private readonly PoupancaRepository _poupancaRepository;
        #endregion

        #region Construtor
        public PoupancaService(PoupancaRepository poupancaRepository)
        {
            _poupancaRepository = poupancaRepository;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Poupanca p, Usuario usuario)
        {
            return _poupancaRepository.Cadastrar(p, usuario);
        }
        #endregion

        #region Editar
        public bool Editar(Poupanca p)
        {
            return _poupancaRepository.Editar(p);

        }
        #endregion

        #region Remover
        public bool Remover(int? idPoupanca)
        {
            var poupanca = Obter(idPoupanca);
            return _poupancaRepository.Remover(poupanca);
        }
        #endregion

        #region Listar
        public List<Poupanca> Listar(int idUsuario)
        {
            return _poupancaRepository.Listar(idUsuario);
        }
        #endregion

        #region Obter
        public Poupanca Obter(int? idPoupanca)
        {
            return _poupancaRepository.Obter(idPoupanca);
        }
        #endregion

        #region CalculoMesAtual
        public double CalculoMesAtual(int idUsuario)
        {
            var resultado = 0.0;
            var depositos = ListarMesAtual(idUsuario);
            foreach (var item in depositos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion

        #region CalculoDiaAtual
        public double CalculoDiaAtual(int idUsuario)
        {
            var resultado = 0.0;
            var lancamentos = ListarDia(idUsuario);
            foreach (var item in lancamentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion

        #region CalculoMesPassado
        public double CalculoMesPassado(int idUsuario)
        {
            var resultado = 0.0;
            var lancamentos = ListarMesPassado(idUsuario);
            foreach (var item in lancamentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion

        #region CalculoQuinzenal
        public double CalculoQuinzenal(int idUsuario)
        {
            var resultado = 0.0;
            var lancamentos = ListarQuinzenal(idUsuario);
            foreach (var item in lancamentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion

        #region ListarDia
        public List<Poupanca> ListarDia(int idUsuario)
        {
            return _poupancaRepository.ListarDia(idUsuario);
        }
        #endregion

        #region ListarMesAtual
        public List<Poupanca> ListarMesAtual(int idUsuario)
        {
            return _poupancaRepository.ListarMesAtual(idUsuario);
        }
        #endregion

        #region ListarMesPassado
        public List<Poupanca> ListarMesPassado(int idUsuario)
        {
            return _poupancaRepository.ListarMesPassado(idUsuario);
        }
        #endregion

        #region ListarQuinzenal
        public List<Poupanca> ListarQuinzenal(int idUsuario)
        {
            return _poupancaRepository.ListarQuinzenal(idUsuario);
        }
        #endregion
    }
}
