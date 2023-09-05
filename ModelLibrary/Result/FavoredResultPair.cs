namespace ModelLibrary.Result;

public class FavoredResultPair: ModelLibrary.Result.FavoredResult
{
    private readonly ModelLibrary.Die.FavoredDie secondFavoredDie;

    #region Properties
    public byte SecondFace { get; }

    public byte SecondFavoredFace => this.secondFavoredDie.FavoredFace;
    public byte SecondFavorFactor => this.secondFavoredDie.FavorFactor;
    #endregion

    public FavoredResultPair(ModelLibrary.Die.FavoredDie firstFavoredDie,
    ModelLibrary.Die.FavoredDie secondFavoredDie): base(favoredDie: firstFavoredDie)
    {
        this.secondFavoredDie = secondFavoredDie;
        this.SecondFace       = ModelLibrary.Die.Die.ValidFace(
            face: this.secondFavoredDie.Roll());
    }
}