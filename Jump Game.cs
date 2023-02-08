public class Solution {
    public int Jump(int[] nums) {
           
            if (nums[0] == 0 || nums.Length == 1) return 0;
            var currJumpPosition = nums[0];
            var nextHighJumpPosition = currJumpPosition;
            var totJump = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {

                nextHighJumpPosition = Math.Max(nextHighJumpPosition, nums[i]);
                if (currJumpPosition == 0)
                {
                    currJumpPosition = nextHighJumpPosition;
                    totJump++;
                }

                currJumpPosition--;
                nextHighJumpPosition--;
            }
            return totJump;
        
    }
}