public class Solution {
    public int Divide(int dividend, int divisor)
{
    if (divisor == 1)
    {
        return dividend;
    }
    else if (dividend == Int32.MinValue&& divisor == -1)
    {
        return Int32.MaxValue;
    }
    else if (divisor == -1)
    {
        return dividend * -1;
    }
    
    return dividend / divisor;
}
}