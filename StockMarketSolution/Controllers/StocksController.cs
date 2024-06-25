using Microsoft.AspNetCore.Mvc;

namespace StockMarketSolution.Controllers
{
	[Route("[controller]")]
	public class StocksController : Controller
	{
		
		public async Task<IActionResult> Explore()
		{
			return View();
		}
	}
}
