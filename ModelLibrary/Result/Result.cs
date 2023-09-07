namespace ModelLibrary.Result;

public class Result
{
    public const string FaceFieldName = nameof(ModelLibrary.Result.Result.face);

    private byte face;

    #region Properties
    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public ModelLibrary.Die.Die? Die { get; }

    public byte Face => this.face;
    #endregion

    #region Constructors
    public Result(): base() {}

    public Result(ModelLibrary.Die.Die die): base()
    {
        this.Die  = die                                                  ;
        this.face = ModelLibrary.Die.Die.ValidFace(face: this.Die.Roll());
    }
    #endregion
}