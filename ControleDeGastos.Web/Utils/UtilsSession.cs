using Microsoft.AspNetCore.Http;
using System;

namespace ControleDeGastos.Web.Utils
{
    public class UtilsSession
    {
        private readonly IHttpContextAccessor _http;
        private readonly string ID_USUARIO = "idUsuario";
        public UtilsSession(IHttpContextAccessor http)
        {
            _http = http;
        }
        public string RetonarUsuarioId()
        {
            if (_http.HttpContext.Session.
                GetString(ID_USUARIO) == null)
            {
                _http.HttpContext.Session.SetString
                    (ID_USUARIO, Guid.NewGuid().ToString());
            }
            return _http.HttpContext.Session.
                GetString(ID_USUARIO);
        }
    }
}
