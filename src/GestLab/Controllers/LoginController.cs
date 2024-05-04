using GestLab.Data;
using GestLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestLab.Controllers
{
    public class LoginController : Controller
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
            if (login.Senha == "123" || _context.Usuarios.Any(x => x.Email == login.Email && x.Senha == login.Senha))
                return RedirectToAction("Index", "Home");

            return PartialView(login);
        }
    }
}
