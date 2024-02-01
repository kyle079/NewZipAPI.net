using System.Text.Json;
using NewZipAPI;
using Xunit.Abstractions;

namespace NewZipAPITester;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    public void TestLeadSubmit()
    {
        var leadInformation =
            new LeadInformation(
                "John", 
                "Doe", 
                "John@gmail.com", 
                "402-791-0001", 
                true, 
                "123 Main St", 
                1000000);
        var request = new NewZipLeadRequest(LeadType.Buyer, leadInformation);
        _testOutputHelper.WriteLine("Request:");
        _testOutputHelper.WriteLine(JsonSerializer.Serialize(request));
        using var service = new NewZipService().SubmitLeadAsync(request);
        Assert.True(service.Result.Success);
        _testOutputHelper.WriteLine("Response:");
        _testOutputHelper.WriteLine(JsonSerializer.Serialize(service.Result));
    }
}