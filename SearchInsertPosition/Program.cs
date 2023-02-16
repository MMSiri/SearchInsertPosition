internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
    }
}

public class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target || nums[i] > target) return i;
            else continue;
        }
        return nums.Length;
    }
}