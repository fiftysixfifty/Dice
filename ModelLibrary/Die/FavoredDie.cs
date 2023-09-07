namespace ModelLibrary.Die;

[System.ComponentModel.DataAnnotations.Schema.TableAttribute(
    name: nameof(ModelLibrary.Die.FavoredDie))]
public class FavoredDie: ModelLibrary.Die.Die
{
    #region Consts
    public const string
        FavoredDieIdFieldName = nameof(ModelLibrary.Die.FavoredDie.favoredDieId),
        FavoredFaceFieldName  = nameof(ModelLibrary.Die.FavoredDie.favoredFace ),
        FavorFactorFieldName  = nameof(ModelLibrary.Die.FavoredDie.favorFactor );
    public const string
        FavoredDieIdColumnName = nameof(ModelLibrary.Die.FavoredDie.FavoredDieId),
        FavoredFaceColumnName  = nameof(ModelLibrary.Die.FavoredDie.FavoredFace ),
        FavorFactorColumnName  = nameof(ModelLibrary.Die.FavoredDie.FavorFactor );

    public const byte MaxFactor = 5;
    #endregion

    #region Fields
    #pragma warning disable CS0649
    private int favoredDieId;
    #pragma warning restore CS0649

    private byte favoredFace, favorFactor;
    #endregion

    #region Properties
    [System.ComponentModel.DataAnnotations.KeyAttribute()]
    public int FavoredDieId => this.favoredDieId;

    public byte FavoredFace => this.favoredFace;
    public byte FavorFactor => this.favorFactor;
    #endregion

    #region Constructors
    public FavoredDie(): base() {}

    public FavoredDie(System.Random random, byte favoredFace, byte favorFactor):
    base(random: random)
    {
        this.favoredFace = ModelLibrary.Die.FavoredDie.ValidFace  (face  : favoredFace);
        this.favorFactor = ModelLibrary.Die.FavoredDie.ValidFactor(factor: favorFactor);
    }
    #endregion

    #region Methods
    internal static byte ValidFactor(byte factor) => ModelLibrary.Util.Util.Valid(
        maxValue: ModelLibrary.Die.FavoredDie.MaxFactor, value: factor);

    public override byte Roll()
    {
        byte resultFaceArrayCount;
        {
            byte extraFaceCount = (byte) (this.favorFactor - 1);

            resultFaceArrayCount = (byte)
                (ModelLibrary.Die.FavoredDie.MaxFace + extraFaceCount);
        }
        byte[] resultFaceArray = new byte[resultFaceArrayCount];

        for (byte i = 0; i < ModelLibrary.Die.FavoredDie.MaxFace; i++)
            resultFaceArray[i] = (byte) (i + 1);

        for (byte i = ModelLibrary.Die.FavoredDie.MaxFace; i < resultFaceArrayCount; i++)
            resultFaceArray[i] = this.favoredFace;

        return resultFaceArray[this.Random.Next(maxValue: resultFaceArrayCount)];
    }
    #endregion
}