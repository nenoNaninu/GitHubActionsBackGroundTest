using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1;
public class UnitTest1
{
    private readonly ITestOutputHelper _output;

    public UnitTest1(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public async Task Test1()
    {
        var url = "https://localhost:7125/weatherforecast";

        var client = new HttpClient();

        try
        {
            var response = await client.GetAsync(url);
            Assert.True(response.IsSuccessStatusCode);
        }
        catch(Exception e)
        {
            _output.WriteLine(e.Message);
            Assert.True(false);
        }
    }
}