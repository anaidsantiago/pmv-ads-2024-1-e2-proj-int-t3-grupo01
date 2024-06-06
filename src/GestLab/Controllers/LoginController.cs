using GestLab.Data;
using GestLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using GestLab.Shared;

namespace GestLab.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly GestLabContext _context;

        public LoginController(ILogger<LoginController> logger, GestLabContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return PartialView(new LoginModel());
        }

        [HttpPost]
        public IActionResult Index(LoginModel login)
        {
            if (login.Email == "admin@admin.com" && login.Senha == "123!@#")
            {
                HttpContext.Session.SetInt32(Constantes.SessionKeyID, 0);
                HttpContext.Session.SetString(Constantes.SessionKeyNome, "Administrador");
                HttpContext.Session.SetString(Constantes.SessionKeyEmail, login.Email);
                HttpContext.Session.SetString(Constantes.SessionKeyTipo, "ADM");

                return RedirectToAction("Index", "Home");
            }
            else if (_context.Usuarios.Any(x => x.Email == login.Email && x.Senha == login.Senha))
            {
                UsuarioModel usuario = _context.Usuarios.Where(x => x.Email == login.Email && x.Senha == login.Senha).FirstOrDefault();
                HttpContext.Session.SetInt32(Constantes.SessionKeyID, usuario.Id);
                HttpContext.Session.SetString(Constantes.SessionKeyNome, usuario.Nome);
                HttpContext.Session.SetString(Constantes.SessionKeyEmail, usuario.Email);
                HttpContext.Session.SetString(Constantes.SessionKeyTipo, usuario.Tipo);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Tipo"] = "Erro";
                TempData["Mensagem"] = "E-mail ou senha inválidos.";

                return PartialView(login);
            }
        }
    }
}
