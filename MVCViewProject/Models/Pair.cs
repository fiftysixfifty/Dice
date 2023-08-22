namespace MVCViewProject.Models;

internal class Pair
{
	private readonly Die firstDie, secondDie;

    internal Pair(Die firstDie, Die secondDie): base()
	{ this.firstDie = firstDie; this.secondDie = secondDie; }

	internal PairRoll Roll() => new PairRoll(
		pair: this                                                 ,
		roll: (byte) (this.firstDie.Roll() + this.secondDie.Roll()));

    public override string ToString() => $"{this.firstDie},{this.secondDie}";
}