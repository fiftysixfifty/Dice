namespace ModelLibrary.Agent;

public class FavoredPairAgent: ModelLibrary.Agent.FavoredAgent
{
    private ModelLibrary.Die.FavoredDie? secondFavoredDie = null;

    #region Properties
    private ModelLibrary.Specification.FavoredPairSpecification
        FavoredPairSpecification =>
    (this.specification as ModelLibrary.Specification.FavoredPairSpecification)!;

    private ModelLibrary.Die.FavoredDie SecondFavoredDie =>
    this.secondFavoredDie ??= (ModelLibrary.Die.FavoredDie) this.MakeDie(
        favoredFace: this.FavoredPairSpecification.SecondFavoredFace,
        favorFactor: this.FavoredPairSpecification.SecondFavorFactor);
    #endregion

    public FavoredPairAgent(
    ModelLibrary.Specification.FavoredPairSpecification favoredPairSpecification):
    base(favoredSpecification: favoredPairSpecification) {}

    public new ModelLibrary.Result.FavoredResultPairList Execute()
    {
        ModelLibrary.Result.FavoredResultPairList result =
            new ModelLibrary.Result.FavoredResultPairList(
                capacity: this.specification.NumberOfTimesToRoll);

        for (byte i = 0; i < this.specification.NumberOfTimesToRoll; i++)
            result.Add(item: new ModelLibrary.Result.FavoredResultPair(
                firstFavoredDie : this.FavoredDie      ,
                secondFavoredDie: this.SecondFavoredDie));

        return result;
    }
}