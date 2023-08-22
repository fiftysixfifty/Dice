namespace MVCViewProject.Models;

internal class PairRoll
{
    private readonly Pair pair;

    public byte Roll { get; }

    internal PairRoll(Pair pair, byte roll): base()
    { this.pair = pair; this.Roll = roll; }

    public override string ToString() => $"{this.pair.ToString()},{this.Roll}";
}