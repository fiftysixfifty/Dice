namespace MVCViewProject.Models;

internal class Pair
{
    private Random? random = null;

    #region Properties
    internal Die FirstDie  { get; }
    internal Die SecondDie { get; }

    private Random Random => this.random ??= new Random();
    #endregion

    internal Pair(Die firstDie, Die secondDie): base()
    { this.FirstDie = firstDie; this.SecondDie = secondDie; }

    #region Methods
    public override string ToString() => $"{this.FirstDie},{this.SecondDie}";

    internal PairRoll Roll() => new PairRoll(
        pair        : this                                    ,
        firstUpFace : this.FirstDie.Roll (random: this.Random),
        secondUpFace: this.SecondDie.Roll(random: this.Random));
    #endregion
}