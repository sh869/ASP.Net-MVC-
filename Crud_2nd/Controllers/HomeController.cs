using System.Diagnostics;
using Crud_2nd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crud_2nd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly    AppleContext context;

        public HomeController(ILogger<HomeController> logger, AppleContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<AppleContext> Apple=context.Apple
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
