namespace MVCViewProject.Models;

internal class Roller
{
    #region Fields
    private readonly byte numberOfTimesToRoll;
    private readonly Pair pair               ;
    #endregion

    internal Roller(MVCViewProject.ViewModels.Index indexViewModel): base()
    {
        this.numberOfTimesToRoll = indexViewModel.NumberOfTimesToRoll;

        this.pair = new Pair(
            firstDie: new Die(
                favoredFace: indexViewModel.FirstFavoredFace,
                favorFactor: indexViewModel.FirstFavorFactor),
            secondDie: new Die(
                favoredFace: indexViewModel.SecondFavoredFace,
                favorFactor: indexViewModel.SecondFavorFactor));
    }

    internal PairRollList Roll()
    {
        PairRollList result = new PairRollList(capacity: this.numberOfTimesToRoll);

        for (byte i = 0; i < this.numberOfTimesToRoll; i++)
            result.Add(item: pair.Roll());

        return result;
    }
}