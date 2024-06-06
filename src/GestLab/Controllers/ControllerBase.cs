using GestLab.Models;
using GestLab.Shared;
using Microsoft.AspNetCore.Mvc;

namespace GestLab.Controllers
{
    public class ControllerBase : Controller
    {
        protected UsuarioModel GetDadosUsuario()
        {
            var usuario = new UsuarioModel
            {
                Id = Convert.ToInt32(HttpContext.Session.GetInt32(Constantes.SessionKeyID)),
                Nome = HttpContext.Session.GetString(Constantes.SessionKeyNome),
                Email = HttpContext.Session.GetString(Constantes.SessionKeyEmail),
                Tipo = HttpContext.Session.GetString(Constantes.SessionKeyTipo)
            };

            Constantes.UsuarioModel = usuario;
            return usuario;
        }
    }
}
