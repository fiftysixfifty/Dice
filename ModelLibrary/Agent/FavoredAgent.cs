namespace ModelLibrary.Agent;

public class FavoredAgent: ModelLibrary.Agent.Agent
{
    #region Properties
    private ModelLibrary.Specification.FavoredSpecification FavoredSpecification =>
        (this.specification as ModelLibrary.Specification.FavoredSpecification)!;

    private protected ModelLibrary.Die.FavoredDie FavoredDie =>
    (ModelLibrary.Die.FavoredDie) this.Die;
    #endregion

    #region Private Protected Methods
    private protected virtual ModelLibrary.Die.Die MakeDie(
    byte favoredFace, byte favorFactor) => new ModelLibrary.Die.FavoredDie(
        random: this.Random, favoredFace: favoredFace, favorFactor: favorFactor);

    private protected override ModelLibrary.Die.Die MakeDie() => this.MakeDie(
        favoredFace: this.FavoredSpecification.FavoredFace,
        favorFactor: this.FavoredSpecification.FavorFactor);
    #endregion

    public FavoredAgent(
    ModelLibrary.Specification.FavoredSpecification favoredSpecification):
    base(specification: favoredSpecification) {}

    public new ModelLibrary.Result.FavoredResultList Execute()
    {
        ModelLibrary.Result.FavoredResultList result =
            new ModelLibrary.Result.FavoredResultList(
                capacity: this.specification.NumberOfTimesToRoll);

        for (byte i = 0; i < this.specification.NumberOfTimesToRoll; i++)
            result.Add(item: new ModelLibrary.Result.FavoredResult(
                favoredDie: this.FavoredDie));

        return result;
    }
}