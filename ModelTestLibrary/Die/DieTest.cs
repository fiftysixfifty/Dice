namespace ModelTestLibrary.Die;

internal class DieTest
{
    [NUnit.Framework.TestAttribute()]
    public void RollIsWithinRange()
    {
        System.Random        random = new System.Random()       ;
        ModelLibrary.Die.Die die    = new ModelLibrary.Die.Die();
        byte                 roll                               ;

        for (byte i = 0; i < 100; i++)
        {
            roll = die.Roll(random: random);

            const byte minValue = 1, maxValue = 6;

            NUnit.Framework.Assert.GreaterOrEqual(arg1: roll, arg2: minValue);
            NUnit.Framework.Assert.LessOrEqual   (arg1: roll, arg2: maxValue);
        }
    }
}