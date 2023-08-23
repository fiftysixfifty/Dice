namespace MVCViewProject.Models;

internal class PairRoll
{
    private readonly Pair pair;

    #region Properties
    internal byte FirstFavoredFace => this.pair.FirstDie.FavoredFace;
    internal byte FirstFavorFactor => this.pair.FirstDie.FavorFactor;

    internal byte SecondFavoredFace => this.pair.SecondDie.FavoredFace;
    internal byte SecondFavorFactor => this.pair.SecondDie.FavorFactor;

    internal byte FirstRoll  { get; }
    internal byte SecondRoll { get; }

    internal byte Roll => (byte) (this.FirstRoll + this.SecondRoll);
    #endregion

    internal PairRoll(Pair pair, byte firstRoll, byte secondRoll) : base()
    { this.pair = pair; this.FirstRoll = firstRoll; this.SecondRoll = secondRoll; }

    public override string ToString() =>
    $"{this.pair.ToString()},{this.FirstRoll},{this.SecondRoll}";
}