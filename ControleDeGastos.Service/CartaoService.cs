using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using ControleDeGastos.Services.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class CartaoService : ICartaoService<Cartao>
    {
        #region Atributos
        private readonly ICartaoRepository<Cartao> _cartaoRepository;
        #endregion

        #region Construtor
        public CartaoService(ICartaoRepository<Cartao> cartaoRepository)
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

        #region Excluir
        public bool Excluir(Cartao c)
        {
            return _cartaoRepository.Excluir(c);
        }
        #endregion

        #region Listar
        public List<Cartao> Listar(int idusuario)
        {
            return _cartaoRepository.Listar(idusuario);
        }
        #endregion

        #region ObterCartaoPorId
        public Cartao ObterCartaoPorId(int idCartao)
        {
            return _cartaoRepository.ObterCartaoPorId(idCartao);
        }
        #endregion
    }
}
