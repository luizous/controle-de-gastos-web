using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Service.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class CartaoService : ICartaoService<Cartao>
    {
        #region Atributos
        private readonly CartaoRepository _cartaoRepository;
        #endregion

        #region Construtor
        public CartaoService(CartaoRepository cartaoRepository)
        {
            _cartaoRepository  = cartaoRepository;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Cartao c, Usuario usuario)
        {
            return _cartaoRepository.Cadastrar(c, usuario);
        }
        #endregion

        #region Remover
        public bool Remover(int? idCartao)
        {
            var cartao = Obter(idCartao);
            return _cartaoRepository.Remover(cartao);
        }
        #endregion

        #region Listar
        public List<Cartao> Listar(int idusuario)
        {
            return _cartaoRepository.Listar(idusuario);
        }
        #endregion

        #region Obter
        public Cartao Obter(int? idCartao)
        {
            return _cartaoRepository.Obter(idCartao);
        }
        #endregion
    }
}
