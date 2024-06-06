using GestLab.Data;
using GestLab.Models;
using GestLab.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            return View("Index", usuario);
        }

        [HttpPost]
        public IActionResult Detail(UsuarioViewModel usuarioView)
        {
            var usuario = usuarioView.Usuario;

            if (usuario.Id == 0)
                _context.Usuarios.Add(usuario);
            else
                _context.Usuarios.Update(usuario);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var usuario = RecuperaUsuario(id);

            if (usuario == null)
            {
                return NotFound();
            }

            UsuarioViewModel usuarioModel = new(usuario);

            usuarioModel.Tipos = StaticLists.ObterTiposUsuario().Select(x => new SelectListItem() { Text = x, Value = x });

            return View("Detail", usuarioModel);
        }

        private UsuarioModel RecuperaUsuario(int id)
        {
            UsuarioModel usuario = null;

            if (id > 0)
            {
                usuario = _context.Usuarios
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
            }

            if (id == 0) usuario = new();

            return usuario;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
