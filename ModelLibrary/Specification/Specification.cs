namespace ModelLibrary.Specification;

public class Specification
{
    private byte numberOfTimesToRoll;

    [System.ComponentModel.DataAnnotations.RangeAttribute(
        minimum: 1, maximum: byte.MaxValue)]
    public byte NumberOfTimesToRoll
    {
        get => this.numberOfTimesToRoll;

        set
        {
            this.numberOfTimesToRoll = ModelLibrary.Util.Util.Valid(
                maxValue: byte.MaxValue, value: value);
        }
    }
}