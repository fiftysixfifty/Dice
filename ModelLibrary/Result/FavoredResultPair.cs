namespace ModelLibrary.Result;

[System.ComponentModel.DataAnnotations.Schema.TableAttribute(
    name: nameof(ModelLibrary.Result.FavoredResultPair))]
public class FavoredResultPair: ModelLibrary.Result.FavoredResult
{
    #region Properties
    [System.ComponentModel.DataAnnotations.KeyAttribute()]
    public int FavoredResultPairId { get; set; }

    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public ModelLibrary.Die.FavoredDie SecondFavoredDie { get; }

    public int FirstFavoredDieId  { get; set; }
    public int SecondFavoredDieId { get; set; }

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