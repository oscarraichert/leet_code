using Services;

namespace Tests;

public class ReverseStringTests
{
    [Theory]
    [InlineData(new char[] {'h', 'e', 'l', 'l', 'o'}, new char[] {'o', 'l', 'l', 'e', 'h'})]
    [InlineData(new char[] {'H', 'a', 'n', 'n', 'a', 'h'}, new char[] {'h', 'a', 'n', 'n', 'a', 'H'})]
    public void ShouldReverseString(char[] s, char[] expected)
    {
        Assert.Equal(expected, ReverseStringService.ReverseString(s));
    }
}
