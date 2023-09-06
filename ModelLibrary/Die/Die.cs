namespace ModelLibrary.Die;

public class Die
{
    public const byte MaxFace = 6;

    private System.Random? random = null;

    private protected System.Random Random => this.random ??= new System.Random();

    #region Constructors
    public Die(): base() {}

    public Die(System.Random random): base() => this.random = random;
    #endregion

    #region Methods
    internal static byte ValidFace(byte face) => ModelLibrary.Util.Util.Valid(
        maxValue: ModelLibrary.Die.Die.MaxFace, value: face);

    public virtual byte Roll() =>
    (byte) (this.Random.Next(maxValue: ModelLibrary.Die.Die.MaxFace) + 1);
    #endregion
}