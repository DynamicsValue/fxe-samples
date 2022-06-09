using Microsoft.Xrm.Sdk;

namespace TestProject;

public class Issue37: FakeXrmEasyTestsBase
{
    [Fact]
    public void Should_run_test()
    {
        _service.Create(new Entity("contact") {});

        var contactCreated = _context.CreateQuery("contact").FirstOrDefault();
        Assert.NotNull(contactCreated);
    }
}