namespace ModelLibrary.Result;

public class Result
{
    private protected readonly ModelLibrary.Die.Die die;

    public byte Face { get; }

    public Result(ModelLibrary.Die.Die die): base()
    {
        this.die  = die                                                  ;
        this.Face = ModelLibrary.Die.Die.ValidFace(face: this.die.Roll());
    }
}