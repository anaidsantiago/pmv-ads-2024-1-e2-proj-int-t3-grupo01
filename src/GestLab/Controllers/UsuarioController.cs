using GestLab.Data;
using GestLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestLab.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly GestLabContext _context;

        public UsuarioController(ILogger<UsuarioController> logger, GestLabContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var usuario = _context.Usuarios.ToList();
            return View(usuario);
        }

        public ActionResult Detail(int? id)
        {
            if (id == 0)
            {
                return View("Detail", new UsuarioModel());
            }

            if (id == null)
            {
                return NotFound();
            }

            var usuario = _context.Usuarios.Find(id);

            return View("Detail", usuario);
        }

        public void AddUsuario()
        {
            UsuarioModel user = new()
            {
                Nome = "Test",
                Senha = "Test",
                Email = "Test",
                Telefone = "Test",
                Tipo = "Test",
            };

            _context.Usuarios.Add(user);
            _context.SaveChanges();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
