namespace ModelLibrary.Agent;

public class PairAgent: ModelLibrary.Agent.Agent
{
    private ModelLibrary.Die.Die? secondDie = null;

    private ModelLibrary.Die.Die SecondDie => this.secondDie ??= this.MakeDie();

    public PairAgent(ModelLibrary.Specification.Specification specification):
    base(specification: specification) {}

    public new ModelLibrary.Result.ResultPairList Execute()
    {
        ModelLibrary.Result.ResultPairList result =
            new ModelLibrary.Result.ResultPairList(
                capacity: this.specification.NumberOfTimesToRoll);

        for (byte i = 0; i < this.specification.NumberOfTimesToRoll; i++)
            result.Add(item: new ModelLibrary.Result.ResultPair(
                firstDie: this.Die, secondDie: this.SecondDie));

        return result;
    }
}