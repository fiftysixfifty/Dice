namespace ModelLibrary.Die;

[System.ComponentModel.DataAnnotations.Schema.TableAttribute(
    name: nameof(ModelLibrary.Die.FavoredDie))]
public class FavoredDie: ModelLibrary.Die.Die
{
    public const byte MaxFactor = 5;

    #region Properties
    [System.ComponentModel.DataAnnotations.KeyAttribute()]
    public int Id { get; set; }

    public byte FavoredFace { get; set; }
    public byte FavorFactor { get; set; }
    #endregion

    #region Constructors
    public FavoredDie(): base() {}

    public FavoredDie(System.Random random, byte favoredFace, byte favorFactor):
    base(random: random)
    {
        this.FavoredFace = ModelLibrary.Die.FavoredDie.ValidFace  (face  : favoredFace);
        this.FavorFactor = ModelLibrary.Die.FavoredDie.ValidFactor(factor: favorFactor);
    }
    #endregion

    #region Methods
    internal static byte ValidFactor(byte factor) => ModelLibrary.Util.Util.Valid(
        maxValue: ModelLibrary.Die.FavoredDie.MaxFactor, value: factor);

    public override byte Roll()
    {
        byte resultFaceArrayCount;
        {
            byte extraFaceCount = (byte) (this.FavorFactor - 1);

            resultFaceArrayCount = (byte)
                (ModelLibrary.Die.FavoredDie.MaxFace + extraFaceCount);
        }
        byte[] resultFaceArray = new byte[resultFaceArrayCount];

        for (byte i = 0; i < ModelLibrary.Die.FavoredDie.MaxFace; i++)
            resultFaceArray[i] = (byte) (i + 1);

        for (byte i = ModelLibrary.Die.FavoredDie.MaxFace; i < resultFaceArrayCount; i++)
            resultFaceArray[i] = this.FavoredFace;

        return resultFaceArray[this.Random.Next(maxValue: resultFaceArrayCount)];
    }
    #endregion
}