public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] nums = new int [nums1.Length + nums2.Length];
            int i = 0, j = 0, k = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    nums[k] = nums1[i];
                    i++;
                }
                else
                {
                    nums[k] = nums2[j];
                    j++;
                }
                k++;
            }
            while (i < nums1.Length)
            {
                nums[k] = nums1[i];
                i++;
                k++;
            }
            while (j < nums2.Length)
            {
                nums[k] = nums2[j];
                j++;
                k++;
            }
            if (nums.Length % 2 == 0)
            {
                return (nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2.0;
            }
            else
            {
                return nums[nums.Length / 2];
            }
        
    }
}