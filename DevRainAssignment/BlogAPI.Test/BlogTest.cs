using BlogREST_API.Interfaces;
using BlogREST_API.Models;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BlogAPI.Test
{
    public class BlogTest
    {
        
        [Fact]
        public void MethodShouldReturnNotNull()
        {
            var mockRepository = new Mock<IBlogRepository>();
            mockRepository.Setup(a => a.GetAllItems()).Returns(new List<Blog>());
            var controller = mockRepository.Object;

            Assert.NotNull(controller);
        }
    }
}
