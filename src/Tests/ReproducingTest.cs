namespace Tests
{
    using System.Net;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.TestHost;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using StartupRepro;

    [TestClass]
    public class ReproducingTest
    {
        [TestMethod]
        public async Task ShouldResolveRoutesCorrectly()
        {
            var host = new WebHostBuilder().UseStartup<Startup>();

            var statusCode = await GetFooStatusCode(host);

            Assert.AreNotEqual(HttpStatusCode.NotFound, statusCode);
        }

        [TestMethod]
        public async Task ShouldResolveRoutesCorrectly2()
        {
            var host = new WebHostBuilder().UseStartup<TestStartup>();

            var statusCode = await GetFooStatusCode(host);

            Assert.AreNotEqual(HttpStatusCode.NotFound, statusCode);
        }

        private async Task<HttpStatusCode> GetFooStatusCode(IWebHostBuilder host)
        {
            var testServer = new TestServer(host);
            var testClient = testServer.CreateClient();

            var result = await testClient.GetAsync("/api/foo");

            return result.StatusCode;
        }
    }
}
