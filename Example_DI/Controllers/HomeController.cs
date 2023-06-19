using Example_DI.Providers;
using Microsoft.AspNetCore.Mvc;

namespace Example_DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvider _provider;

        public HomeController(IProvider provider)
        {
            _provider = provider;
        }

        public IActionResult Index()
        {
            return View(_provider.GetUsers());
        }
    }
}