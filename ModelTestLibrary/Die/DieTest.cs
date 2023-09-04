namespace ModelTestLibrary.Die;

internal class DieTest
{
    private System.Random? random;

    private protected System.Random Random => this.random ??= new System.Random();

    #region Private Protected Methods
    private protected virtual ModelLibrary.Die.Die MakeDie() =>
    new ModelLibrary.Die.Die(random: this.Random);

    private protected virtual void VirtualRollIsWithinRange()
    {
        ModelLibrary.Die.Die die  = this.MakeDie();
        byte                 roll                 ;

        for (byte i = 0; i < 100; i++)
        {
            roll = die.Roll();

            const byte minValue = 1, maxValue = 6;

            NUnit.Framework.Assert.GreaterOrEqual(arg1: roll, arg2: minValue);
            NUnit.Framework.Assert.LessOrEqual   (arg1: roll, arg2: maxValue);
        }
    }
    #endregion

    [NUnit.Framework.TestAttribute()]
    public void RollIsWithinRange() => this.VirtualRollIsWithinRange();
}