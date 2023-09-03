namespace ModelLibrary.Result;

public class Result
{
    #region Properties
    public ModelLibrary.Die.Die Die  { get; }
    public byte                 Face { get; }
    #endregion

    public Result(ModelLibrary.Die.Die die): base()
    {
        this.Die  = die                                                  ;
        this.Face = ModelLibrary.Die.Die.ValidFace(face: this.Die.Roll());
    }
}