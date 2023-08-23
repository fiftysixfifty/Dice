namespace MVCViewProject.Models;

internal class Pair
{
    #region Properties
    internal Die FirstDie  { get; }
    internal Die SecondDie { get; }
    #endregion

    internal Pair(Die firstDie, Die secondDie): base()
    { this.FirstDie = firstDie; this.SecondDie = secondDie; }

    #region Methods
    public override string ToString() => $"{this.FirstDie},{this.SecondDie}";

    internal PairRoll Roll() => new PairRoll(
        pair: this                                                 ,
        roll: (byte) (this.FirstDie.Roll() + this.SecondDie.Roll()));
    #endregion
}