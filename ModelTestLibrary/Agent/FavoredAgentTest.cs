namespace ModelTestLibrary.Agent;

internal class FavoredAgentTest
{
    [NUnit.Framework.TestAttribute()]
    public void BadSpecificationFails() => NUnit.Framework.Assert.Throws<
        System.ArgumentException>(code: () => new ModelLibrary.Agent.FavoredAgent(
            specification: new ModelLibrary.Specification.Specification()));

    [NUnit.Framework.TestAttribute()]
    public void GoodSpecificationSucceeds() => NUnit.Framework.Assert.DoesNotThrow(
        code: () => new ModelLibrary.Agent.FavoredAgent(
            specification: new ModelLibrary.Specification.FavoredSpecification()));
}