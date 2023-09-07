namespace ModelLibrary.Result;

public class Result
{
    #region Properties
    [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
    public ModelLibrary.Die.Die Die { get; }

    [System.ComponentModel.DataAnnotations.Schema.ColumnAttribute(name: "FirstFace")]
    public byte Face { get; }
    #endregion

    public Result(ModelLibrary.Die.Die die): base()
    {
        this.Die  = die                                                  ;
        this.Face = ModelLibrary.Die.Die.ValidFace(face: this.Die.Roll());
    }
}