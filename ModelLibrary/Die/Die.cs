namespace ModelLibrary.Die;

public class Die
{
    public const byte MaxFace = 6;

    private protected readonly System.Random random;

    public Die(System.Random random): base() => this.random = random;

    #region Methods
    internal static byte ValidFace(byte face) => ModelLibrary.Util.Util.Valid(
        maxValue: ModelLibrary.Die.Die.MaxFace, value: face);

    public virtual byte Roll() =>
    (byte) (this.random.Next(maxValue: ModelLibrary.Die.Die.MaxFace) + 1);
    #endregion
}