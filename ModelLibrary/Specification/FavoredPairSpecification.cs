namespace ModelLibrary.Specification;

public class FavoredPairSpecification: ModelLibrary.Specification.FavoredSpecification
{
    private byte secondFavoredFace, secondFavorFactor;

    [System.ComponentModel.DataAnnotations.RangeAttribute(
        minimum: 1, maximum: ModelLibrary.Die.Die.MaxFace)]
    public byte SecondFavoredFace
    {
        get => this.secondFavoredFace;

        set { this.secondFavoredFace = ModelLibrary.Die.Die.ValidFace(face: value); }
    }

    [System.ComponentModel.DataAnnotations.RangeAttribute(
        minimum: 1, maximum: ModelLibrary.Die.FavoredDie.MaxFactor)]
    public byte SecondFavorFactor
    {
        get => this.secondFavorFactor;

        set
        {
            this.secondFavorFactor =
                ModelLibrary.Die.FavoredDie.ValidFactor(factor: value);
        }
    }
}