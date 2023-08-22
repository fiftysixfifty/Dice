namespace MVCViewProject.Models;

internal class Die
{
	private const byte maxFaceValue = 6;

    #region Fields
    private readonly byte    favoredFace, favorFactor;
	private          Random? random = null           ;
	#endregion

	private Random Random => this.random ??= new Random();

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
		this.favoredFace = Die.ValidFace  (value: favoredFace);
		this.favorFactor = Die.ValidFactor(value: favorFactor);
	}

    public override string ToString() =>
	$"favoredFace:{this.favoredFace},favorFactor:{this.favorFactor}";

    internal byte Roll()
	{
		byte upFace = (byte) (this.Random.Next(maxValue: Die.maxFaceValue) + 1);

		return upFace == this.favoredFace ? (byte) (upFace * this.favorFactor) : upFace;
	}
}