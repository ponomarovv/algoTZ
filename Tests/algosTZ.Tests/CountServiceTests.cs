namespace algosTZ.Tests;

public class CountServiceTests
{
    [Theory]
    [InlineData('a', 1, 5, "abcdj", 1)] // Should return 1 because 'a' appears 3 times.
    [InlineData('z', 2, 4, "asfalseiruqwo", 0)] // Should return 0 because 'z' appears 0 times.
    [InlineData('b', 3, 6, "bhhkkbbjjjb", 1)] // Should return 1 because 'b' appears 4 times.
    [InlineData('a', 1, 3, "aabbac", 1)] // Should return 1 because 'a' appears 3 times.
    [InlineData('x', 1, 3, "abcdefgh", 0)] // Should return 0 because 'x' is not in the input.
    [InlineData('a', 5, 7, "abcabcabc", 0)] // Should return 0 because 'a' appears 3 times.
    [InlineData('a', 2, 4, "aaaaaa", 0)] // Should return 1 because 'a' appears 6 times, but within the count range.
    [InlineData('a', 2, 4, "a", 0)] // Should return 1 because 'a' appears 1 time, but within the count range.
    [InlineData('z', 2, 4, "asfalseiruqwozzzzz", 0)] // Should return 0 because 'a' appears 5 times.
    [InlineData('z', 2, 4, "asfalseiruqwoz", 0)] // Should return 0 because 'a' appears 1 time.
    public void CountLine_ShouldReturnExpectedResult(char c, int minCount, int maxCount, string input, int expected)
    {
        int counter = 0;
        int result = CountService.CountLine(c, minCount, maxCount, input, ref counter);
        Assert.Equal(expected, result);
    }
}

