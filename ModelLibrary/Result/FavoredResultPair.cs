namespace ModelLibrary.Result;

[System.ComponentModel.DataAnnotations.Schema.TableAttribute(
    name: nameof(ModelLibrary.Result.FavoredResultPair))]
public class FavoredResultPair: ModelLibrary.Result.FavoredResult
{
    #region Consts
    public const string
        FavoredResultPairIdFieldName =
            nameof(ModelLibrary.Result.FavoredResultPair.favoredResultPairId),
        SecondFaceFieldName = nameof(ModelLibrary.Result.FavoredResultPair.secondFace);
    public const string
        FavoredResultPairIdColumnName =
            nameof(ModelLibrary.Result.FavoredResultPair.FavoredResultPairId),
        SecondFaceColumnName = nameof(ModelLibrary.Result.FavoredResultPair.SecondFace);
    #endregion

    #region Fields
    #pragma warning disable CS0649
    private int  favoredResultPairId;
    private byte secondFace         ;
    #pragma warning restore CS0649
    #endregion

    #region Properties
    [System.ComponentModel.DataAnnotations.KeyAttribute()]
    public int FavoredResultPairId => this.favoredResultPairId;

    public int FirstFavoredDieId  { get; set; }
    public int SecondFavoredDieId { get; set; }

    public byte SecondFace => this.secondFace;

    #region Navigation Properties
    [System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute(
        name: nameof(ModelLibrary.Result.FavoredResultPair.FirstFavoredDieId))]
    public ModelLibrary.Die.FavoredDie? FirstFavoredDie
    { get => this.FavoredDie; init => this.FavoredDie = value; }

    [System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute(
        name: nameof(ModelLibrary.Result.FavoredResultPair.SecondFavoredDieId))]
    public ModelLibrary.Die.FavoredDie? SecondFavoredDie { get; init; }
    #endregion
    #endregion

    #region Constructors
    public FavoredResultPair(): base() {}

    public FavoredResultPair(ModelLibrary.Die.FavoredDie firstFavoredDie,
    ModelLibrary.Die.FavoredDie secondFavoredDie): base(favoredDie: firstFavoredDie)
    {
        this.SecondFavoredDie = secondFavoredDie;
        this.secondFace       = ModelLibrary.Die.Die.ValidFace(
            face: this.SecondFavoredDie.Roll());
    }
    #endregion
}