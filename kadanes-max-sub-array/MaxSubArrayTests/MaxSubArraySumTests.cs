namespace MaxSubArrayTests;

public class MaxSubArraySumTests
{
    [Fact]
    public void Empty() =>
        Assert.Equal(0, MaxSubArray.Array.MaxSubArraySum([]));

    [Fact]
    public void Single() =>
        Assert.Equal(3, MaxSubArray.Array.MaxSubArraySum([3]));

    [Theory]
    [InlineData(new int[] { -4, 10 }, 10)]
    [InlineData(new int[] { 10, -4 }, 10)]
    [InlineData(new int[] { -6, -4 }, -4)]
    [InlineData(new int[] { 4, 6 }, 10)]
    public void Double(int[] input, int expected) =>
        Assert.Equal(expected, MaxSubArray.Array.MaxSubArraySum(input));

    [Theory]
    [InlineData(new int[] { -1, 2, -5, 7 }, 7)]
    [InlineData(new int[] { -1, 2, -5, 2, 7 }, 9)]
    [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    [InlineData(new int[] { -2, 4, -1, 2, 1, -5, 4, -9, 7, 8 }, 15)]
    public void NAry(int[] input, int expected) =>
        Assert.Equal(expected, MaxSubArray.Array.MaxSubArraySum(input));
}