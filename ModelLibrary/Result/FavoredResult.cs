namespace ModelLibrary.Result;

public class FavoredResult: ModelLibrary.Result.Result
{
    #region Properties
    private ModelLibrary.Die.FavoredDie FavoredDie =>
        (this.die as ModelLibrary.Die.FavoredDie)!;

    public byte FavoredFace => this.FavoredDie.FavoredFace;
    public byte FavorFactor => this.FavoredDie.FavorFactor;
    #endregion

    public FavoredResult(ModelLibrary.Die.FavoredDie favoredDie):
    base(die: favoredDie) {}
}