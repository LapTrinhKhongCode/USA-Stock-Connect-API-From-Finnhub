using ServiceContracts;
using Services;
using StockMarketSolution;
using StockMarketSolution.StartupExtension;

var builder = WebApplication.CreateBuilder(args);



builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();


