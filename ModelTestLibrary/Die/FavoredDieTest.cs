namespace ModelTestLibrary.Die;

internal class FavoredDieTest: ModelTestLibrary.Die.DieTest
{
    private protected override ModelLibrary.Die.Die MakeDie() =>
    new ModelLibrary.Die.FavoredDie(
        random: this.Random, favoredFace: 4, favorFactor: 3);

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
    public new void RollIsWithinRange() => this.VirtualRollIsWithinRange();
}