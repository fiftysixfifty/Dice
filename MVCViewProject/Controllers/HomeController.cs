using Microsoft.AspNetCore.Mvc ;
using MVCViewProject.Models    ;
using System.Diagnostics       ;
using MVCViewProject.ViewModels;

namespace MVCViewProject.Controllers;

public class HomeController: Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger): base() =>
    this._logger = logger;

    #region Methods
    public IActionResult Index  () => this.View();
    public IActionResult Privacy() => this.View();

    [HttpPostAttribute                ()]
    [ValidateAntiForgeryTokenAttribute()]
    public string? RollList(MVCViewProject.ViewModels.Index indexViewModel)
    {
        PairRollList pairRollList = new Roller(indexViewModel: indexViewModel).Roll();

        return pairRollList.ToString();
    }

    [ResponseCacheAttribute(
        Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => this.View(model: new Error()
        { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
    #endregion
}