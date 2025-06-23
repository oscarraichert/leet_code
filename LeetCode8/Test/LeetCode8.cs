﻿namespace Test;

public class LeetCode8
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData("   -042", -42)]
    [InlineData("1337c0d3", 1337)]
    [InlineData("0-1", 0)]
    [InlineData("words and 987", 0)]
    public void AtoITest(string s, int expected)
    {
        Assert.Equal(expected, AtoI.Atoi(s));
    }
}
