namespace MVCViewProject.Controllers;

public class HomeController: Microsoft.AspNetCore.Mvc.Controller
{
    private readonly Microsoft.Extensions.Logging.ILogger<
        MVCViewProject.Controllers.HomeController> logger;

    public HomeController(Microsoft.Extensions.Logging.ILogger<
        MVCViewProject.Controllers.HomeController> logger): base() =>
    this.logger = logger;

    #region Methods
    public Microsoft.AspNetCore.Mvc.IActionResult Index  () => this.View();
    public Microsoft.AspNetCore.Mvc.IActionResult Privacy() => this.View();


    [Microsoft.AspNetCore.Mvc.HttpPostAttribute                ()]
    [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryTokenAttribute()]
    public Microsoft.AspNetCore.Mvc.IActionResult PairRollList(
    MVCViewProject.ViewModels.Index indexViewModel)
    {
        MVCViewProject.Models.PairRollList pairRollList =
            new MVCViewProject.Models.Roller(indexViewModel: indexViewModel).Roll();

        return this.View(model: MVCViewProject.Services.PairRoll.Add(
            pairRollList: pairRollList));
    }

    [Microsoft.AspNetCore.Mvc.HttpPostAttribute                ()]
    [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryTokenAttribute()]
    public Microsoft.AspNetCore.Mvc.IActionResult ResultList(
    ModelLibrary.Specification.Specification specification) => this.View(model:
        new ModelLibrary.Agent.Agent(specification: specification).Execute());

    [Microsoft.AspNetCore.Mvc.HttpPostAttribute()]
    [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryTokenAttribute()]
    public Microsoft.AspNetCore.Mvc.IActionResult ResultPairList(
    ModelLibrary.Specification.Specification specification) => this.View(model:
        new ModelLibrary.Agent.PairAgent(specification: specification).Execute());

    [Microsoft.AspNetCore.Mvc.HttpPostAttribute                ()]
    [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryTokenAttribute()]
    public Microsoft.AspNetCore.Mvc.IActionResult FavoredResultList(
    ModelLibrary.Specification.FavoredSpecification favoredSpecification) => this.View(
        model: new ModelLibrary.Agent.FavoredAgent(
            favoredSpecification: favoredSpecification).Execute());

    [Microsoft.AspNetCore.Mvc.HttpPostAttribute                ()]
    [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryTokenAttribute()]
    public Microsoft.AspNetCore.Mvc.IActionResult FavoredResultPairList(
    ModelLibrary.Specification.FavoredPairSpecification favoredPairSpecification) =>
    this.View(model: new ModelLibrary.Agent.FavoredPairAgent(
        favoredPairSpecification: favoredPairSpecification).Execute());


    [Microsoft.AspNetCore.Mvc.ResponseCacheAttribute(
        Duration = 0                                                  ,
        Location = Microsoft.AspNetCore.Mvc.ResponseCacheLocation.None,
        NoStore  = true                                               )]
    public Microsoft.AspNetCore.Mvc.IActionResult Error() => this.View(model:
        new MVCViewProject.ViewModels.Error()
        {
            RequestId = System.Diagnostics.Activity.Current?.Id
                ?? this.HttpContext.TraceIdentifier
        });
    #endregion
}