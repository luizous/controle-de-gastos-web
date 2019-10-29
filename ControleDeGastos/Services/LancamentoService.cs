using ControleDeGastos.DAL.Interfaces;

namespace ControleDeGastos.Services
{
    public class LancamentoService
    {
        #region Atributos
        private readonly ILancamentoDAO _lancamentoDAO;
        #endregion

        #region Construtor
        private LancamentoService(ILancamentoDAO lancamentoDAO)
        {
            _lancamentoDAO = lancamentoDAO;
        }
        #endregion

        #region CalculoDiaAtual
        public double CalculoDiaAtual(int idUsuario)
        {
            var resultado = 0.0;
            var lancamentos = _lancamentoDAO.ListarLancamentoDia(idUsuario);
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
            var lancamentos = _lancamentoDAO.ListarLancamentoMesAtual(idUsuario);
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
            var lancamentos = _lancamentoDAO.ListarLancamentoMesPassado(idUsuario);
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
            var lancamentos = _lancamentoDAO.ListarLancamentoQuinzenal(idUsuario);
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
            var lancamentos = _lancamentoDAO.ListarPorCategoria(idUsuario, idCategoria);
            foreach (var item in lancamentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion
    }
}
