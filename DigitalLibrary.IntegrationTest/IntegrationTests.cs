using DigitalLibrary.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace DigitalLibrary.IntegrationTest
{
    public class IntegrationTests
    {
        public HttpClient Client;
        public IntegrationTests()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = server.CreateClient();
        }
        [Fact]
        public async Task Description_NoCondition_Success()
        {
            var response = await Client.GetAsync("/Welcome/Description");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal("This is the application for managing digital books!"
                , responseString);
        }
    }
}
