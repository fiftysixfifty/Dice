namespace ModelTestLibrary.Specification;

internal class FavoredPairSpecificationTest
{
    [NUnit.Framework.TestAttribute()]
    public void SetLowFavoredFaceFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            {
                new ModelLibrary.Specification.FavoredPairSpecification()
                    .SecondFavoredFace = 0;
            });

    [NUnit.Framework.TestAttribute()]
    public void SetHighFavoredFaceFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            {
                new ModelLibrary.Specification.FavoredPairSpecification()
                    .SecondFavoredFace = 7;
            });

    [NUnit.Framework.TestAttribute()]
    public void SetGoodFavoredFaceSucceeds() =>
    NUnit.Framework.Assert.DoesNotThrow(code: () =>
        {
            new ModelLibrary.Specification.FavoredPairSpecification()
                .SecondFavoredFace = 2;
        });


    [NUnit.Framework.TestAttribute()]
    public void SetLowFavorFactorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            {
                new ModelLibrary.Specification.FavoredPairSpecification()
                    .SecondFavorFactor = 0;
            });

    [NUnit.Framework.TestAttribute()]
    public void SetHighFavorFactorFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentOutOfRangeException>(code: () =>
            {
                new ModelLibrary.Specification.FavoredPairSpecification()
                    .SecondFavorFactor = 6;
            });

    [NUnit.Framework.TestAttribute()]
    public void SetGoodFavorFactorSucceeds() =>
    NUnit.Framework.Assert.DoesNotThrow(code: () =>
        {
            new ModelLibrary.Specification.FavoredPairSpecification()
                .SecondFavorFactor = 2;
        });
}