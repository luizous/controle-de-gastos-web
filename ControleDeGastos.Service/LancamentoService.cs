using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using ControleDeGastos.Services.Interfaces;

namespace ControleDeGastos.Services
{
    public class LancamentoService : ILancamentoService<Lancamento>
    {
        #region Atributos
        private readonly ILancamentoRepository<Lancamento> _lancamentoRepository;
        #endregion

        #region Construtor
        private LancamentoService(ILancamentoRepository<Lancamento> lancamentoRepository)
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

        #region CalculoDiaAtual
        public double CalculoDiaAtual(int idUsuario)
        {
            var resultado = 0.0;
            var lancamentos = _lancamentoRepository.ListarLancamentoDia(idUsuario);
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
            var lancamentos = _lancamentoRepository.ListarLancamentoMesAtual(idUsuario);
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
            var lancamentos = _lancamentoRepository.ListarLancamentoMesPassado(idUsuario);
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
            var lancamentos = _lancamentoRepository.ListarLancamentoQuinzenal(idUsuario);
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
            var lancamentos = _lancamentoRepository.ListarPorCategoria(idUsuario, idCategoria);
            foreach (var item in lancamentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion
    }
}
