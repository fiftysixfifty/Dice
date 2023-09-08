namespace ModelLibrary.Result;

public class FavoredResult: ModelLibrary.Result.Result
{
    #region Properties
    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public ModelLibrary.Die.FavoredDie? FavoredDie
    {
                          get  => this.die as ModelLibrary.Die.FavoredDie;
        private protected init => this.die = value                       ;
    }


    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public byte FavoredFace =>
    null == this.FavoredDie ? (byte) 0 : this.FavoredDie.FavoredFace;

    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public byte FavorFactor =>
    null == this.FavoredDie ? (byte) 0 : this.FavoredDie.FavorFactor;
    #endregion

    #region Constructors
    public FavoredResult(): base() {}

    public FavoredResult(ModelLibrary.Die.FavoredDie favoredDie):
    base(die: favoredDie) {}
    #endregion
}