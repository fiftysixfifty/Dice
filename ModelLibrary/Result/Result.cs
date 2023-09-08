namespace ModelLibrary.Result;

public class Result
{
    public const string
        FaceFieldName  = nameof(ModelLibrary.Result.Result.face),
        FaceColumnName = "FirstFace"                            ;

    #region Fields
    private protected ModelLibrary.Die.Die? die ;
    private           byte                  face;
    #endregion

    public byte Face => this.face;

    #region Constructors
    public Result(): base() {}

    public Result(ModelLibrary.Die.Die die): base()
    {
        this.die  = die                                                  ;
        this.face = ModelLibrary.Die.Die.ValidFace(face: this.die.Roll());
    }
    #endregion
}