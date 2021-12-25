using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1;
public class UnitTest1
{
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
        catch
        {
            Assert.True(false);
        }
    }
}