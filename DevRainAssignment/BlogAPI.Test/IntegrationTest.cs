using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Xunit;

namespace BlogAPI.Test
{
    public class IntegrationTest: IClassFixture<WebApplicationFactory<BlogREST_API.Startup>>
    {
        private readonly WebApplicationFactory<BlogREST_API.Startup> _factory;

        public IntegrationTest(WebApplicationFactory<BlogREST_API.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/blogs")]
        [InlineData("/api/blogs/2")]
        [InlineData("/api/blogs/1/comments")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); 
            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
