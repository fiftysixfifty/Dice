namespace ModelTestLibrary.Specification;

internal class FavoredSpecificationTest
{
    [NUnit.Framework.TestAttribute()]
    public void SetLowFavoredFaceFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            { new ModelLibrary.Specification.FavoredSpecification().FavoredFace = 0; });

    [NUnit.Framework.TestAttribute()]
    public void SetHighFavoredFaceFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            { new ModelLibrary.Specification.FavoredSpecification().FavoredFace = 7; });

    [NUnit.Framework.TestAttribute()]
    public void SetGoodFavoredFaceSucceeds() =>
    NUnit.Framework.Assert.DoesNotThrow(code: () =>
        { new ModelLibrary.Specification.FavoredSpecification().FavoredFace = 2; });


    [NUnit.Framework.TestAttribute()]
    public void SetLowFavorFactorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            { new ModelLibrary.Specification.FavoredSpecification().FavorFactor = 0; });

    [NUnit.Framework.TestAttribute()]
    public void SetHighFavorFactorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            { new ModelLibrary.Specification.FavoredSpecification().FavorFactor = 6; });

    [NUnit.Framework.TestAttribute()]
    public void SetGoodFavorFactorSucceeds() =>
    NUnit.Framework.Assert.DoesNotThrow(code: () =>
        { new ModelLibrary.Specification.FavoredSpecification().FavorFactor = 2; });
}