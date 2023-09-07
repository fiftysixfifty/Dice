namespace ModelLibrary.Result;

public class FavoredResultPair: ModelLibrary.Result.FavoredResult
{
    #region Properties
    public ModelLibrary.Die.FavoredDie SecondFavoredDie { get; }

    public byte SecondFace { get; }
    #endregion

    public FavoredResultPair(ModelLibrary.Die.FavoredDie firstFavoredDie,
    ModelLibrary.Die.FavoredDie secondFavoredDie): base(favoredDie: firstFavoredDie)
    {
        this.SecondFavoredDie = secondFavoredDie;
        this.SecondFace       = ModelLibrary.Die.Die.ValidFace(
            face: this.SecondFavoredDie.Roll());
    }
}