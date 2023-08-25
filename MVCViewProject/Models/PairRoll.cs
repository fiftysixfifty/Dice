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

    public byte FirstUpFace  { get; set; }
    public byte SecondUpFace { get; set; }
    #endregion

    #region Constructors
    public PairRoll(): base() {}

    internal PairRoll(Pair pair, byte firstUpFace, byte secondUpFace): this()
    {
        this.pair = pair;

        this.FirstFavoredFace = this.pair.FirstDie.FavoredFace;
        this.FirstFavorFactor = this.pair.FirstDie.FavorFactor;

        this.SecondFavoredFace = this.pair.SecondDie.FavoredFace;
        this.SecondFavorFactor = this.pair.SecondDie.FavorFactor;


        this.FirstUpFace  = firstUpFace;
        this.SecondUpFace = secondUpFace;
    }
    #endregion

    public override string ToString() =>
    $"{this.pair?.ToString() ?? "<null>"},{this.FirstUpFace},{this.SecondUpFace}";
}