using ControleDeGastos.Domain;
using ControleDeGastos.Repository;
using ControleDeGastos.Service.Interfaces;
using System.Collections.Generic;

namespace ControleDeGastos.Service
{
    public class MetaService : IMetaService<Meta>
    {
        #region Atributos
        private readonly MetaRepository _metaRepository;
        private readonly UsuarioRepository _usuarioRepository;
        #endregion

        #region Construtor
        public MetaService(MetaRepository metaRepository, UsuarioRepository usuarioRepository)
        {
            _metaRepository = metaRepository;
            _usuarioRepository = usuarioRepository;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Meta m, int idUsuario)
        {
            m.Conquistada = false;
            var usuario = _usuarioRepository.Obter(idUsuario);
            return _metaRepository.Cadastrar(m, usuario);
        }
        #endregion

        #region Remover
        public bool Remover(int? idMeta)
        {
            var categoria = Obter(idMeta);
            return _metaRepository.Remover(categoria);
        }
        #endregion

        #region Conquistada
        public bool Conquistada(int? idMeta)
        {
            var categoria = Obter(idMeta);
            if (categoria.Conquistada)
                categoria.Conquistada = false;
            else
                categoria.Conquistada = true;
            return _metaRepository.Conquistada(categoria);
        }
        #endregion

        #region Listar
        public List<Meta> Listar(int idUsuario)
        {
            return _metaRepository.Listar(idUsuario);
        }
        #endregion

        #region Obter
        public Meta Obter(int? idMeta)
        {
            return _metaRepository.Obter(idMeta);
        }
        #endregion
    }
}
