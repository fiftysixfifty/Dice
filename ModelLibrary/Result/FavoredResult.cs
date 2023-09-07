namespace ModelLibrary.Result;

public class FavoredResult: ModelLibrary.Result.Result
{
    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public ModelLibrary.Die.FavoredDie? FavoredDie =>
        this.Die as ModelLibrary.Die.FavoredDie;

    #region Constructors
    public FavoredResult(): base() {}

    public FavoredResult(ModelLibrary.Die.FavoredDie favoredDie):
    base(die: favoredDie) {}
    #endregion
}