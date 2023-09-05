namespace ModelTestLibrary.Result;

internal class FavoredResultTest
{
    private System.Random? random = null;

    private System.Random Random => this.random ??= new System.Random();

    #region Methods
    [NUnit.Framework.TestAttribute()]
    public void BadDieFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentException>(code: () => new ModelLibrary.Result.FavoredResult(
            die: new ModelLibrary.Die.Die(random: this.Random)));

    [NUnit.Framework.TestAttribute()]
    public void GoodDieSucceeds() => NUnit.Framework.Assert.DoesNotThrow(code: () =>
        new ModelLibrary.Result.FavoredResult(die: new ModelLibrary.Die.FavoredDie(
            random: this.Random, favoredFace: 4, favorFactor: 3)));
    #endregion
}