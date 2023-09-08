namespace ModelLibrary.Result;

public class ResultPair: ModelLibrary.Result.Result
{
    #region Properties
    public byte FirstFace  => this.Face;
    public byte SecondFace { get; }
    #endregion

    public ResultPair(ModelLibrary.Die.Die firstDie, ModelLibrary.Die.Die secondDie):
    base(die: firstDie) =>
    this.SecondFace = ModelLibrary.Die.Die.ValidFace(face: secondDie.Roll());
}