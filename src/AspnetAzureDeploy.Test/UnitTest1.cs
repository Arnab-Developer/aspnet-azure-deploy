using AspnetAzureDeploy.WebApp.Controllers;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace AspnetAzureDeploy.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeController homeController = new(new Mock<ILogger<HomeController>>().Object);
            IActionResult actionResult = homeController.Index();
            Assert.Equal("Index", ((ViewResult)actionResult).ViewName);
        }
    }
}
