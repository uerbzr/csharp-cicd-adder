using workshop.service.adder;

namespace workshop.tests;

public class Tests
{
    [Test]
    public void Adding1and2Equals3()
    {
        AddingService addingService = new();
        int result = 3;
        int a = 1;
        int b = 2;
        Assert.That(result, Is.EqualTo(addingService.Calculate(a, b)));
    }
    [TestCase(1,2,3)]
    [TestCase(2, 2, 4)]
    [TestCase(9, 9, 18)]
    [TestCase(19, 1, 20)]
    [TestCase(1, 1, 2)]
    public void AddingTests(int a, int b, int result)
    {
        AddingService addingService = new();        
        Assert.That(result, Is.EqualTo(addingService.Calculate(a, b)));
    }
}
