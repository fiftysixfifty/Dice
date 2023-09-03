namespace ModelLibrary.Die;

public class FavoredDie: ModelLibrary.Die.Die
{
    private readonly byte favoredFace, favorFactor;

    private static byte ValidFactor(byte factor) =>
    ModelLibrary.Die.FavoredDie.Valid(maxValue: 5, value: factor);

    public FavoredDie(byte favoredFace, byte favorFactor): base()
    {
        this.favoredFace = ModelLibrary.Die.FavoredDie.ValidFace  (face  : favoredFace);
        this.favorFactor = ModelLibrary.Die.FavoredDie.ValidFactor(factor: favorFactor);
    }

    #region Methods
    public override string ToString() =>
    $"favoredFace:{this.favoredFace},favorFactor:{this.favorFactor}";

    public override byte Roll(System.Random random)
    {
        byte upFaceArrayCount;
        {
            byte extraFaceCount = (byte) (this.favorFactor - 1);

            upFaceArrayCount = (byte)
                (ModelLibrary.Die.FavoredDie.maxFace + extraFaceCount);
        }
        byte[] upFaceArray = new byte[upFaceArrayCount];

        for (byte i = 0; i < ModelLibrary.Die.FavoredDie.maxFace; i++)
            upFaceArray[i] = (byte) (i + 1);

        for (byte i = ModelLibrary.Die.FavoredDie.maxFace; i < upFaceArrayCount; i++)
            upFaceArray[i] = this.favoredFace;

        return upFaceArray[random.Next(maxValue: upFaceArrayCount)];
    }
    #endregion
}