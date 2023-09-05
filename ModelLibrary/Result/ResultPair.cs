namespace ModelLibrary.Result;

public class ResultPair: ModelLibrary.Result.Result
{
    private readonly ModelLibrary.Die.Die secondDie;

    public byte SecondFace { get; }

    public ResultPair(ModelLibrary.Die.Die firstDie, ModelLibrary.Die.Die secondDie):
    base(die: firstDie)
    {
        this.secondDie  = secondDie                                                  ;
        this.SecondFace = ModelLibrary.Die.Die.ValidFace(face: this.secondDie.Roll());
    }
}