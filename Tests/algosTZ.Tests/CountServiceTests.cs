namespace algosTZ.Tests;

public class CountServiceTests
{
    [Theory]
    [InlineData('a', 1, 5, "abcdj", 1)] // Should return 1 because 'a' appears 1 time.
    [InlineData('a', 1, 3, "aabbac", 1)] // Should return 1 because 'a' appears 3 times.
    [InlineData('a', 5, 7, "abcabcabc", 0)] // Should return 0 because 'a' appears 3 times.
    [InlineData('a', 2, 4, "a", 0)] // Should return 0 because 'a' appears 1 time, but within the count range.
    [InlineData('a', 2, 4, "as", 0)]
    [InlineData('a', 2, 4, "sa", 0)]
    [InlineData('a', 2, 4, "sas", 0)]
    [InlineData('a', 2, 4, "aa", 1)] 
    [InlineData('a', 2, 4, "asa", 1)] 
    [InlineData('a', 2, 4, "asas", 1)] 
    [InlineData('a', 2, 4, "sasa", 1)] 
    [InlineData('a', 2, 4, "sasas", 1)] 
    [InlineData('a', 2, 4, "aaa", 1)] 
    [InlineData('a', 2, 4, "aaaa", 1)] 
    [InlineData('a', 2, 4, "aaaaaa", 0)] // Should return 1 because 'a' appears 6 times, but within the count range.
    [InlineData('z', 2, 4, "asfalseiruqwo", 0)] // Should return 0 because 'z' appears 0 times.
    [InlineData('b', 3, 6, "bhhkkbbjjjb", 1)] // Should return 1 because 'b' appears 4 times.
    [InlineData('x', 1, 3, "abcdefgh", 0)] // Should return 0 because 'x' is not in the input.
    [InlineData('z', 2, 4, "asfalseiruqwozzzzzz", 0)] 
    [InlineData('z', 2, 4, "asfalseiruqwoz", 0)] // Should return 0 because 'a' appears 1 time.
    [InlineData('z', 2, 4, "azsfalseiruqwoz", 1)]
    [InlineData('z', 2, 4, "zasfalseiruqwoz", 1)]
    [InlineData('z', 2, 4, "asfalsezziruqwo", 1)]
    
    [InlineData('z', 2, 4, "zzzzasfalseiruqwo", 1)]
    [InlineData('z', 2, 4, "asfalseiruqwozzzz", 1)]
    [InlineData('z', 2, 4, "asfalseizzzzruqwo", 1)]
    [InlineData('z', 2, 4, "asfalseizzszzruqwo", 1)]
    
    [InlineData('z', 2, 4, "zasfalseiruqwozzzz", 0)]
    [InlineData('z', 2, 4, "asfalseiruqwozzzzz", 0)]
    [InlineData('z', 2, 4, "asfalseirzzzzzuqwo", 0)]
    
    [InlineData('z', 0, 0, "asfalseiruqwo", 1)] 
    [InlineData('z', 0, 0, "asfalseiruqwoz", 0)] 
    [InlineData('z', 0, 0, "zasfalseiruqwo", 0)] 
    [InlineData('z', 0, 0, "zasfalseiruqwoz", 0)] 
    [InlineData('z', 0, 0, "zzasfalseziruqwozz", 0)] 
    [InlineData('z', 0, 0, "asfalsezziruqwo", 0)]
    
    
    [InlineData('z', 2, 1, "asfalsezziruqwo", 0)] 

    [InlineData('z', 10, 50, "asfalz", 0)] 
    [InlineData('z', 10, 50, "zzzzzzzzzzzasfalz", 1)] 
    public void CountLine_ShouldReturnExpectedResult(char c, int minCount, int maxCount, string input, int expected)
    {
        int counter = 0;
        int actual = CountService.CountLine(c, minCount, maxCount, input, ref counter);
        Assert.Equal(expected, actual);
    }
}

