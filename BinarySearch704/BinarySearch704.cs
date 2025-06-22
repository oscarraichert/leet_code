
namespace BinarySearch704;

public class BinarySearch704
{
    [Theory]
    [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new int[] { 5 }, 5, 0)]
    public void ShouldReturnIndex(int[] nums, int target, int output)
    {
        Assert.Equal(Solution(nums, target), output);
    }

    [Theory]
    [InlineData(new int[] { 5 }, -5, -1)]
    public void ShouldReturnFalse(int[] nums, int target, int output)
    {
        Assert.Equal(Solution(nums, target), output);
    }

    public int Solution(int[] nums, int target)
    {
        return BinarySearch(target, nums);
    }

    private int BinarySearch(int target, int[] nums)
    {
        int r = 0;
        int f = 0;
        int l = nums.Length - 1;

        while (f <= l)
        {
            var m = f + ((l - f) / 2);

            if (nums[m] < target)
            {
                f = m + 1;
            }

            else if (nums[m] > target)
            {
                l = m - 1;
            }

            else
            {
                r = m;
                break;
            }

            r = -1;
        }

        return r;
    }
}
