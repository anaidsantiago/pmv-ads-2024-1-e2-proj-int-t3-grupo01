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

            var estoque = produtos.GroupBy(x => x.Tipo).Select(x => new EstoqueViewModel() { Tipo = x.Key, QuantidadeTotal = x.Count() }).ToList();

            return View("Index", estoque);
        }

        public ActionResult Detail()
        {
            return View("Detail", new ProdutoViewModel());
        }

        [HttpPost]
        public IActionResult Detail(ProdutoViewModel produtoView)
        {
            for (int i = 0; i < produtoView.Quantidade; i++)
            {
                _context.Produto.Add(new ProdutoModel()
                {
                    Cor = produtoView.Cor,
                    Descricao = produtoView.Descricao,
                    Tipo = produtoView.Tipo
                });
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
