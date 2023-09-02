namespace ModelLibrary.Die;

public class Die
{
    private protected const byte maxFace = 6;

    public virtual byte Roll(System.Random random) =>
    (byte) (random.Next(maxValue: ModelLibrary.Die.Die.maxFace) + 1);
}