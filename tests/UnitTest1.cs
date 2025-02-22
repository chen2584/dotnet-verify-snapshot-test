namespace tests;

public class UnitTest1
{
    [Fact]
    public Task Test()
    {
        return Verify("This is content");
    }
}