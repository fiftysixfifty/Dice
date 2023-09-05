namespace ModelLibrary.Specification;

public class FavoredSpecification: ModelLibrary.Specification.Specification
{
    private byte favoredFace, favorFactor;

    [System.ComponentModel.DataAnnotations.RangeAttribute(
        minimum: 1, maximum: ModelLibrary.Die.Die.MaxFace)]
    public byte FavoredFace
    {
        get => this.favoredFace;

        set { this.favoredFace = ModelLibrary.Die.Die.ValidFace(face: value); }
    }

    [System.ComponentModel.DataAnnotations.RangeAttribute(
        minimum: 1, maximum: ModelLibrary.Die.FavoredDie.MaxFactor)]
    public byte FavorFactor
    {
        get => this.favorFactor;

        set
        { this.favorFactor = ModelLibrary.Die.FavoredDie.ValidFactor(factor: value); }
    }
}