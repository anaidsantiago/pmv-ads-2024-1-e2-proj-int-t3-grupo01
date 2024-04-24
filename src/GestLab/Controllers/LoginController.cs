using GestLab.Data;
using Microsoft.AspNetCore.Mvc;

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
            return PartialView();
        }
    }
}
