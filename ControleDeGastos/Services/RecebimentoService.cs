using ControleDeGastos.DAL.Interfaces;

namespace ControleDeGastos.Services
{
    public class RecebimentoService
    {
        #region Atributos
        private readonly IRecebimentoDAO _recebimentoDAO;
        #endregion

        #region Construtor
        private RecebimentoService(IRecebimentoDAO recebimentoDAO)
        {
            _recebimentoDAO = recebimentoDAO;
        }
        #endregion

        #region CalculoDiaAtual
        public double CalculoDiaAtual(int idUsuario)
        {
            var resultado = 0.0;
            var recebimentos = _recebimentoDAO.ListarRecebimentoDia(idUsuario);
            foreach (var item in recebimentos)
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
            var recebimentos = _recebimentoDAO.ListarRecebimentoMesAtual(idUsuario);
            foreach (var item in recebimentos)
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
            var recebimentos = _recebimentoDAO.ListarRecebimentoMesPassado(idUsuario);
            foreach (var item in recebimentos)
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
            var recebimentos = _recebimentoDAO.ListarRecebimentoQuinzenal(idUsuario);
            foreach (var item in recebimentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion
    }
}
