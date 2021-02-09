using AspnetAzureDeploy.WebApp.Controllers;
using AspnetAzureDeploy.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace AspnetAzureDeploy.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void ViewNameTest()
        {
            HomeController homeController = new(new Mock<ILogger<HomeController>>().Object);
            IActionResult actionResult = homeController.Index();
            Assert.Equal("Index", ((ViewResult)actionResult).ViewName);
        }

        [Fact]
        public void ModelNameTest()
        {
            HomeController homeController = new(new Mock<ILogger<HomeController>>().Object);
            IActionResult actionResult = homeController.Index();
            Assert.IsType<Student>(((ViewResult)actionResult).Model);
        }
    }
}
