using Microsoft.AspNetCore.Mvc;

namespace StockMarketSolution.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
