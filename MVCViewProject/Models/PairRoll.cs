namespace MVCViewProject.Models;

internal class PairRoll
{
    #region Fields
    private readonly Pair pair;
	private readonly byte roll;
    #endregion

    internal PairRoll(Pair pair, byte roll): base()
	{ this.pair = pair; this.roll = roll; }

    public override string ToString() => $"{this.pair.ToString()},{this.roll}";
}