namespace ModelLibrary.Result;

public class ResultPair: ModelLibrary.Result.Result
{
    public byte SecondFace { get; }

    public ResultPair(ModelLibrary.Die.Die firstDie, ModelLibrary.Die.Die secondDie):
    base(die: firstDie) =>
    this.SecondFace = ModelLibrary.Die.Die.ValidFace(face: secondDie.Roll());
}