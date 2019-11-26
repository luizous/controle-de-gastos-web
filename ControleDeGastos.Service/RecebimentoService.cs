using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Service.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class RecebimentoService : IRecebimentoService<Recebimento>
    {
        #region Atributos
        private readonly RecebimentoRepository _recebimentoRepository;
        #endregion

        #region Construtor
        public RecebimentoService(RecebimentoRepository recebimentoRepository)
        {
            _recebimentoRepository = recebimentoRepository;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Recebimento r, Usuario usuario)
        {
            return _recebimentoRepository.Cadastrar(r, usuario);
        }
        #endregion

        #region Editar
        public bool Editar(Recebimento r)
        {
            return _recebimentoRepository.Editar(r);
        }
        #endregion

        #region Listar
        public List<Recebimento> Listar(int idUsuario)
        {
            return _recebimentoRepository.Listar(idUsuario);
        }
        #endregion

        #region Obter
        public Recebimento Obter(int? idRecebimento)
        {
            return _recebimentoRepository.Obter(idRecebimento);
        }
        #endregion

        #region CalculoDiaAtual
        public double CalculoDiaAtual(int idUsuario)
        {
            var resultado = 0.0;
            var recebimentos = _recebimentoRepository.ListarRecebimentoDia(idUsuario);
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
            var recebimentos = _recebimentoRepository.ListarRecebimentoMesAtual(idUsuario);
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
            var recebimentos = _recebimentoRepository.ListarRecebimentoMesPassado(idUsuario);
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
            var recebimentos = _recebimentoRepository.ListarRecebimentoQuinzenal(idUsuario);
            foreach (var item in recebimentos)
            {
                resultado += item.Valor;
            }
            return resultado;
        }
        #endregion
    }
}
