using FluentAssertions;

[TestClass]
public class SimpleMathTests
{
    [TestMethod]
    public void Add_Success()
    {
        // Arrange
        int a = 2;
        int b = 8;
        int expected = a + b;

        // Act
        int result = SimpleMath.Add(a, b);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void Subtract_Success()
    {
        // Arrange
        int a = 9;
        int b = 3;
        int expected = a - b;

        // Act
        int result = SimpleMath.Subtract(a, b);

        // Assert
        result.Should().Be(expected);
    }
    
    [TestMethod]
    public void Multiply_Success()
    {
        // Arrange
        int a = -1;
        int b = 8;
        int expected = a * b;

        // Act
        int result = SimpleMath.Multiply(a, b);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void Divide_Success()
    {
        // Arrange
        int a = 10;
        int b = 2;
        int expected = 10/2;

        // Act
        int result = SimpleMath.Divide(a, b);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void Divide_DivideByZero_ThrowsException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act
        Func<int> act = () => SimpleMath.Divide(a, b);

        // Assert
        act.Should().Throw<DivideByZeroException>();
    }
}