namespace ModelLibrary.Agent;

public class Agent
{
    #region Fields
    private protected readonly ModelLibrary.Specification.Specification specification;

    private System.Random?        random = null;
    private ModelLibrary.Die.Die? die    = null;
    #endregion

    #region Properties
    private protected System.Random Random => this.random ??= new System.Random();

    private protected ModelLibrary.Die.Die Die =>
        this.die ??= new ModelLibrary.Die.Die(random: this.Random);
    #endregion

    public Agent(ModelLibrary.Specification.Specification specification): base() =>
    this.specification = specification;

    public ModelLibrary.Result.ResultList Execute()
    {
        ModelLibrary.Result.ResultList result = new ModelLibrary.Result.ResultList(
            capacity: this.specification.NumberOfTimesToRoll);

        for (byte i = 0; i < this.specification.NumberOfTimesToRoll; i++)
            result.Add(item: new ModelLibrary.Result.Result(die: this.Die));

        return result;
    }
}