using GestLab.Data;
using GestLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestLab.Controllers
{
    public class EstoqueController : Controller
    {
        private readonly ILogger<EstoqueController> _logger;
        private readonly GestLabContext _context;

        public EstoqueController(ILogger<EstoqueController> logger, GestLabContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Produto.ToList();

            var estoque = produtos.GroupBy(x => x.Descricao).Select(x => new EstoqueModel() { Tipo = x.Key, QuantidadeTotal = x.Count() }).ToList();

            return View("Index", estoque);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
