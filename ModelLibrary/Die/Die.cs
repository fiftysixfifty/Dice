namespace ModelLibrary.Die;

public class Die
{
    private protected const byte maxFace = 6;

    private protected readonly System.Random random;

    public Die(System.Random random): base() => this.random = random;

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

    public virtual byte Roll() =>
    (byte) (this.random.Next(maxValue: ModelLibrary.Die.Die.maxFace) + 1);
    #endregion
}