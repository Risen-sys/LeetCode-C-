public class Solution {
    public int Reverse(int x) {
        int Limit = int.MaxValue / 10;
        
        var negvalue = x < 0;
		if (negvalue)
			x = -x;
        
        int answer = 0;
        while(x > 0){
            if(answer > Limit)
				return 0;
			
            answer = 10 * answer + x % 10;
            
            x = x / 10;
        };
        
		if(negvalue)
			answer = -answer;
        
        return answer;
    }
}