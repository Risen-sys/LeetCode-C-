public class Solution {
    public int MaxArea(int[] heights) 
    {
        var maxArea = -1;
        var p1 = 0;
        var p2 = heights.Length - 1;
        while (p1 < p2)
        {
            maxArea = Math.Max(Math.Min(heights[p1], heights[p2]) * (p2 - p1), maxArea);
            if (heights[p1] < heights[p2])
            {
                p1++;
            }
            else
            {
                p2--;
            }
        }

        return maxArea == -1 ? 0 : maxArea;
    }
}