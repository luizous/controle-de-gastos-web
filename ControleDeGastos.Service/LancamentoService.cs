using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Service.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class LancamentoService : ILancamentoService<Lancamento>
    {
        #region Atributos
        private readonly LancamentoRepository _lancamentoRepository;
        #endregion

        #region Construtor
        public LancamentoService(LancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Lancamento l, Usuario usuario)
        {
            return _lancamentoRepository.Cadastrar(l, usuario);
        }
        #endregion

        #region Editar
        public bool Editar(Lancamento l)
        {
            return _lancamentoRepository.Editar(l);

        }
        #endregion

        #region Obter
        public Lancamento Obter(int? idLancamento)
        {
            return _lancamentoRepository.Obter(idLancamento);
        }
        #endregion

        #region Listar
        public List<Lancamento> Listar(int idUsuario)
        {
            return _lancamentoRepository.Listar(idUsuario);
        }
        #endregion

        #region ListarRecentes
        public List<Lancamento> ListarRecentes(int idUsuario)
        {
            return _lancamentoRepository.ListarRecentes(idUsuario);
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

        #region CalculoMesAtual
        public double CalculoMesAtual(int idUsuario)
        {
            var resultado = 0.0;
            var lancamentos = ListarMesAtual(idUsuario);
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

        #region CalculoPorCategoria
        public double CalculoPorCategoria(int idUsuario, int idCategoria)
        {
            var resultado = 0.0;
            var lancamentos = ListarPorCategoria(idUsuario, idCategoria);
            foreach (var item in lancamentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion

        #region ListarDia
        public List<Lancamento> ListarPorCategoria(int idUsuario, int idCategoria)
        {
            return _lancamentoRepository.ListarPorCategoria(idUsuario, idCategoria);
        }
        #endregion

        #region ListarDia
        public List<Lancamento> ListarDia(int idUsuario)
        {
            return _lancamentoRepository.ListarDia(idUsuario);
        }
        #endregion

        #region ListarMesAtual
        public List<Lancamento> ListarMesAtual(int idUsuario)
        {
            return _lancamentoRepository.ListarMesAtual(idUsuario);
        }
        #endregion

        #region ListarMesPassado
        public List<Lancamento> ListarMesPassado(int idUsuario)
        {
            return _lancamentoRepository.ListarMesPassado(idUsuario);
        }
        #endregion

        #region ListarQuinzenal
        public List<Lancamento> ListarQuinzenal(int idUsuario)
        {
            return _lancamentoRepository.ListarQuinzenal(idUsuario);
        }
        #endregion
    }
}
