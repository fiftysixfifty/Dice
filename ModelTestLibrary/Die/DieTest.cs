namespace ModelTestLibrary.Die;

internal class DieTest
{
    private System.Random? random;

    private protected System.Random Random => this.random ??= new System.Random();

    [NUnit.Framework.TestAttribute()]
    public void RollIsWithinRange()
    {
        ModelLibrary.Die.Die die  = new ModelLibrary.Die.Die(random: this.Random);
        byte                 roll                                                ;

        for (byte i = 0; i < 100; i++)
        {
            roll = die.Roll();

            const byte minValue = 1, maxValue = 6;

            NUnit.Framework.Assert.GreaterOrEqual(arg1: roll, arg2: minValue);
            NUnit.Framework.Assert.LessOrEqual   (arg1: roll, arg2: maxValue);
        }
    }
}