namespace MVCViewProject.Models;

internal class Die
{
    private const byte maxFaceValue = 6;

    private Random? random = null;

    #region Properties
    internal byte FavoredFace { get; }
    internal byte FavorFactor { get; }

    private Random Random => this.random ??= new Random();
    #endregion

    #region Private Methods
    private static byte Valid(byte maxValue, byte value)
    {
        if (value < 1 || value > maxValue)
            throw new ArgumentOutOfRangeException();
        else
            return value;
    }

    private static byte ValidFace(byte value) =>
    Die.Valid(maxValue: Die.maxFaceValue, value: value);

    private static byte ValidFactor(byte value) => Die.Valid(maxValue: 5, value: value);
    #endregion

    internal Die(byte favoredFace, byte favorFactor): base()
    {
        this.FavoredFace = Die.ValidFace  (value: favoredFace);
        this.FavorFactor = Die.ValidFactor(value: favorFactor);
    }

    #region Methods
    public override string ToString() =>
    $"favoredFace:{this.FavoredFace},favorFactor:{this.FavorFactor}";

    internal byte Roll()
    {
        byte upFace = (byte) (this.Random.Next(maxValue: Die.maxFaceValue) + 1);

        return upFace == this.FavoredFace ? (byte) (upFace * this.FavorFactor) : upFace;
    }
    #endregion
}