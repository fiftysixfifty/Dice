namespace MVCViewProject.Models;

internal class Die
{
    private const byte maxFace = 6;

    #region Properties
    internal byte FavoredFace { get; }
    internal byte FavorFactor { get; }
    #endregion

    #region Private Methods
    private static byte Valid(byte maxValue, byte value)
    {
        if (value < 1 || value > maxValue)
            throw new ArgumentOutOfRangeException();
        else
            return value;
    }

    private static byte ValidFace(byte face) =>
    Die.Valid(maxValue: Die.maxFace, value: face);

    private static byte ValidFactor(byte factor) =>
    Die.Valid(maxValue: 5, value: factor);
    #endregion

    internal Die(byte favoredFace, byte favorFactor): base()
    {
        this.FavoredFace = Die.ValidFace  (face  : favoredFace);
        this.FavorFactor = Die.ValidFactor(factor: favorFactor);
    }

    #region Methods
    public override string ToString() =>
    $"favoredFace:{this.FavoredFace},favorFactor:{this.FavorFactor}";

    internal byte Roll(Random random)
    {
        byte upFaceArrayCount;
        {
            byte extraFaceCount = (byte) (this.FavorFactor - 1);

            upFaceArrayCount = (byte) (Die.maxFace + extraFaceCount);
        }
        byte[] upFaceArray = new byte[upFaceArrayCount];

        for (byte i = 0; i < Die.maxFace; i++) upFaceArray[i] = (byte) (i + 1);

        for (byte i = Die.maxFace; i < upFaceArrayCount; i++)
            upFaceArray[i] = this.FavoredFace;

        return upFaceArray[random.Next(maxValue: upFaceArrayCount)];
    }
    #endregion
}