namespace ModelLibrary.Result;

public class FavoredResult: ModelLibrary.Result.Result
{
    public ModelLibrary.Die.FavoredDie FavoredDie =>
        (this.Die as ModelLibrary.Die.FavoredDie)!;

    public FavoredResult(ModelLibrary.Die.FavoredDie favoredDie):
    base(die: favoredDie) {}
}