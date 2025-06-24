using Services;

namespace Tests;

public class ValidPalindromeTests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama")]
    public void ShouldBeTrue(string s)
    {
        Assert.True(PalindromeServices.ValidPalindrome(s));
    }
}
