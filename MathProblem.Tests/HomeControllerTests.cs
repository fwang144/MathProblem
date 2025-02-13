using FluentAssertions;
using MathProblem.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace MathProblem.Tests;

[TestClass]
public sealed class HomeControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        var logger = Substitute.For<ILogger<HomeController>>();
        var tempData = Substitute.For<ITempDataDictionary>();
        var controller = new HomeController(logger)
        {
            TempData = tempData
        };

        // Act
        var result = controller.Addition();

        // Assert
        result.Should().BeNull();
        result.Should().BeOfType<ViewResult>();
    }
}
