namespace ModelLibrary.Die;

public class FavoredDie: ModelLibrary.Die.Die
{
    private readonly byte favoredFace, favorFactor;

    private static byte ValidFactor(byte factor) =>
    ModelLibrary.Die.FavoredDie.Valid(maxValue: 5, value: factor);

    public FavoredDie(System.Random random, byte favoredFace, byte favorFactor):
    base(random: random)
    {
        this.favoredFace = ModelLibrary.Die.FavoredDie.ValidFace  (face  : favoredFace);
        this.favorFactor = ModelLibrary.Die.FavoredDie.ValidFactor(factor: favorFactor);
    }

    #region Methods
    public override string ToString() =>
    $"favoredFace:{this.favoredFace},favorFactor:{this.favorFactor}";

    public override byte Roll()
    {
        byte resultFaceArrayCount;
        {
            byte extraFaceCount = (byte) (this.favorFactor - 1);

            resultFaceArrayCount = (byte)
                (ModelLibrary.Die.FavoredDie.maxFace + extraFaceCount);
        }
        byte[] resultFaceArray = new byte[resultFaceArrayCount];

        for (byte i = 0; i < ModelLibrary.Die.FavoredDie.maxFace; i++)
            resultFaceArray[i] = (byte) (i + 1);

        for (byte i = ModelLibrary.Die.FavoredDie.maxFace; i < resultFaceArrayCount; i++)
            resultFaceArray[i] = this.favoredFace;

        return resultFaceArray[random.Next(maxValue: resultFaceArrayCount)];
    }
    #endregion
}