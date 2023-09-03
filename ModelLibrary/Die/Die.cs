namespace ModelLibrary.Die;

public class Die
{
    private protected const byte maxFace = 6;

    #region Methods
    private protected static byte Valid(byte maxValue, byte value)
    {
        if (value < 1 || value > maxValue)
            throw new System.ArgumentOutOfRangeException();
        else
            return value;
    }

    internal static byte ValidFace(byte face) => ModelLibrary.Die.Die.Valid(
        maxValue: ModelLibrary.Die.Die.maxFace, value: face);

    public virtual byte Roll(System.Random random) =>
    (byte) (random.Next(maxValue: ModelLibrary.Die.Die.maxFace) + 1);
    #endregion
}