using System.Collections;
using System.IO.Pipelines;

namespace LeetCode567;

public class PermutationInString
{
    [Theory]
    [InlineData("ab", "aeidbaooo")]
    public void ShouldBeTrue(string s1, string s2)
    {
        Assert.True(CheckInclusion(s1, s2));
    }

    public bool CheckInclusion(string s1, string s2)
    {
        var windowLength = s1.Length;
        var s1a = s1.ToList();
        s1a.Sort();

        for (int i = 0; i < s2.Length; i++)
        {
            if (i > s2.Length - windowLength) return false;

            var window = s2.Substring(i, windowLength);

            var winList = window.ToList();
            winList.Sort();

            if (s1a.SequenceEqual(winList))
            {
                return true;
            }
        }

        return false;
    }
}
