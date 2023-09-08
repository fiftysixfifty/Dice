namespace ModelLibrary.Result;

public class FavoredResult: ModelLibrary.Result.Result
{
    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public ModelLibrary.Die.FavoredDie? FavoredDie
    {
                          get  => this.die as ModelLibrary.Die.FavoredDie;
        private protected init => this.die = value                       ;
    }

    #region Constructors
    public FavoredResult(): base() {}

    public FavoredResult(ModelLibrary.Die.FavoredDie favoredDie):
    base(die: favoredDie) {}
    #endregion
}