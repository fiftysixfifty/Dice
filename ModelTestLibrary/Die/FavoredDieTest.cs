namespace ModelTestLibrary.Die;

internal class FavoredDieTest: ModelTestLibrary.Die.DieTest
{
    #region Constructor Tests
    [NUnit.Framework.TestAttribute()]
    public void LowFavoredFaceConstructorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () => new ModelLibrary.Die.FavoredDie(
            random: this.Random, favoredFace: 0, favorFactor: 3));

    [NUnit.Framework.TestAttribute()]
    public void HighFavoredFaceConstructorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () => new ModelLibrary.Die.FavoredDie(
            random: this.Random, favoredFace: 9, favorFactor: 3));

    [NUnit.Framework.TestAttribute()]
    public void GoodFavoredFaceConstructorSucceeds() =>
    NUnit.Framework.Assert.DoesNotThrow(code: () => new ModelLibrary.Die.FavoredDie(
        random: this.Random, favoredFace: 4, favorFactor: 3));


    [NUnit.Framework.TestAttribute()]
    public void LowFavorFactorConstructorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () => new ModelLibrary.Die.FavoredDie(
            random: this.Random, favoredFace: 4, favorFactor: 0));

    [NUnit.Framework.TestAttribute()]
    public void HighFavorFactorConstructorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () => new ModelLibrary.Die.FavoredDie(
            random: this.Random, favoredFace: 4, favorFactor: 8));

    [NUnit.Framework.TestAttribute()]
    public void GoodFavorFactorConstructorSucceeds() =>
    NUnit.Framework.Assert.DoesNotThrow(code: () => new ModelLibrary.Die.FavoredDie(
        random: this.Random, favoredFace: 4, favorFactor: 3));
    #endregion

    [NUnit.Framework.TestAttribute()]
    public void RollIsWithinRange()
    {
        ModelLibrary.Die.FavoredDie favoredDie = new ModelLibrary.Die.FavoredDie(
            random: this.Random, favoredFace: 4, favorFactor: 3);
        byte roll;

        for (byte i = 0; i < 100; i++)
        {
            roll = favoredDie.Roll();

            const byte minValue = 1, maxValue = 6;

            NUnit.Framework.Assert.GreaterOrEqual(arg1: roll, arg2: minValue);
            NUnit.Framework.Assert.LessOrEqual   (arg1: roll, arg2: maxValue);
        }
    }
}