public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] sol = { };
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j && !sol.Contains(i) && !sol.Contains(j))
                {
                    sol = sol.Concat(new int[] { i, j }).ToArray();
                }
            }
        }
        return sol;
    }
}