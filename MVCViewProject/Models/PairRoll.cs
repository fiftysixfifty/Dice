using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations       ;

namespace MVCViewProject.Models;

[TableAttribute(name: nameof(PairRoll))]
public class PairRoll
{
    private Pair? pair = null;

    #region Properties
    [KeyAttribute()]
    public int Id { get; set; }

    public byte FirstFavoredFace { get; set; }
    public byte FirstFavorFactor { get; set; }

    public byte SecondFavoredFace { get; set; }
    public byte SecondFavorFactor { get; set; }

    public byte FirstRoll  { get; set; }
    public byte SecondRoll { get; set; }

    public byte Roll { get; set; }
    #endregion

    #region Constructors
    public PairRoll(): base() {}

    internal PairRoll(Pair pair, byte firstRoll, byte secondRoll) : this()
    {
        this.pair = pair;

        this.FirstFavoredFace = this.pair.FirstDie.FavoredFace;
        this.FirstFavorFactor = this.pair.FirstDie.FavorFactor;

        this.SecondFavoredFace = this.pair.SecondDie.FavoredFace;
        this.SecondFavorFactor = this.pair.SecondDie.FavorFactor;


        this.FirstRoll  = firstRoll;
        this.SecondRoll = secondRoll;

        this.Roll = (byte) (this.FirstRoll + this.SecondRoll);
    }
    #endregion

    public override string ToString() =>
    $"{this.pair?.ToString() ?? "<null>"},{this.FirstRoll},{this.SecondRoll}";
}