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
    }
}
