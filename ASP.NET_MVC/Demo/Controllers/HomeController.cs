using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
		private readonly DemoContext _context;

		public HomeController(DemoContext context)
		{
			_context = context;
		}
		//public HomeController(ILogger<HomeController> logger)
  //      {
  //          _logger = logger;
  //      }

        public IActionResult Index()
        {
            return View(_context.Product.ToList());
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