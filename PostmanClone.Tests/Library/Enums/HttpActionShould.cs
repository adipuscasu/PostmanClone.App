using FluentAssertions;
using PostmanClone.Library.Enums;

namespace PostmanClone.Tests.Library.Enums;
public class HttpActionShould
{
    [Fact]
    public void BeOfTypeEnum()
    {
        // Arrange
        object obj = HttpAction.Get;

        // Act
        bool isEnum = obj is HttpAction;

        // Assert
        isEnum.Should().BeTrue();
    }

    [Fact]
    public void EnumHasGet()
    {
        // Act
        bool isDefined = Enum.IsDefined(typeof(HttpAction), "Get");

        // Assert
        isDefined.Should().BeTrue();
    }
}
