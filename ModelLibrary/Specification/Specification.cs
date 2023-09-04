namespace ModelLibrary.Specification;

public class Specification
{
    private byte numberOfTimesToRoll;

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