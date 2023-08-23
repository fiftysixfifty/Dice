namespace MVCViewProject.Models;

internal class PairRoll
{
    private readonly Pair pair;

    #region Properties
    internal byte FirstFavoredFace => this.pair.FirstDie.FavoredFace;
    internal byte FirstFavorFactor => this.pair.FirstDie.FavorFactor;

    internal byte SecondFavoredFace => this.pair.SecondDie.FavoredFace;
    internal byte SecondFavorFactor => this.pair.SecondDie.FavorFactor;

    internal byte Roll { get; }
    #endregion

    internal PairRoll(Pair pair, byte roll): base()
    { this.pair = pair; this.Roll = roll; }

    public override string ToString() => $"{this.pair.ToString()},{this.Roll}";
}