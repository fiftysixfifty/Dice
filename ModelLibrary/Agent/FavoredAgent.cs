namespace ModelLibrary.Agent;

public class FavoredAgent: ModelLibrary.Agent.Agent
{
    private ModelLibrary.Specification.FavoredSpecification FavoredSpecification =>
        (this.specification as ModelLibrary.Specification.FavoredSpecification)!;

    private protected override ModelLibrary.Die.Die MakeDie() =>
    new ModelLibrary.Die.FavoredDie(
        random     : this.Random                          ,
        favoredFace: this.FavoredSpecification.FavoredFace,
        favorFactor: this.FavoredSpecification.FavorFactor);

    public FavoredAgent(ModelLibrary.Specification.Specification specification):
    base(specification: specification)
    {
        if (specification is not ModelLibrary.Specification.FavoredSpecification)
            throw new System.ArgumentException();
    }

    public new ModelLibrary.Result.FavoredResultList Execute()
    {
        ModelLibrary.Result.FavoredResultList result =
            new ModelLibrary.Result.FavoredResultList(
                capacity: this.specification.NumberOfTimesToRoll);

        for (byte i = 0; i < this.specification.NumberOfTimesToRoll; i++)
            result.Add(item: new ModelLibrary.Result.FavoredResult(die: this.Die));

        return result;
    }
}