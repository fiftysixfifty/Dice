namespace ModelTestLibrary.Specification;

internal class SpecificationTest
{
    [NUnit.Framework.TestAttribute()]
    public void SetLowNumberOfTimesToRollFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
        {
            new ModelLibrary.Specification.Specification().NumberOfTimesToRoll = 0;
        });

    [NUnit.Framework.TestAttribute()]
    public void SetGoodNumberOfTimesToRollSucceeds() =>
    NUnit.Framework.Assert.DoesNotThrow(code: () =>
        {
            new ModelLibrary.Specification.Specification().NumberOfTimesToRoll = 22;
        });
}