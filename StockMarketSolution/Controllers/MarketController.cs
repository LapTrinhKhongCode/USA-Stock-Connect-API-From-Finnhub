using Microsoft.AspNetCore.Mvc;

namespace StockMarketSolution.Controllers
{
	[Route("[controller]")]
	public class MarketController : Controller
	{
		
		[HttpGet]
		
		public IActionResult Index()
		{
			return View();
		}
	}
}
