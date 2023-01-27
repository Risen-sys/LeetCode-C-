public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var solution = new List<IList<int>>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            // duplicates??
            if (i > 0 && nums[i] == nums[i - 1])
			{
				continue;
			}
            
            // Two point alg
            var l = i + 1;
            var r = nums.Length - 1;
            
            while (l < r)
            {
                if (nums[l] + nums[r] == 0 - nums[i])
                {
                    // Avoid dup
                    if (!solution.Any() || nums[l] != solution.Last()[1] || nums[r] != solution.Last()[2])
                    {
                        var res = new int[] {nums[i], nums[l], nums[r]};
                        solution.Add(res.ToList());
                    }
                    
                    l++;
                    r--;
                }
                else if (nums[l] + nums[r] > 0 - nums[i])
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
        }
        
        return solution;
    }
}