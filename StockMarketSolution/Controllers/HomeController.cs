using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StockMarketSolution.Controllers
{
    [Route("[controller]")]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
