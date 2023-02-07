public class Solution {
    public double Average(int[] salary) {
        int max = 0, min = salary[0];
            int sum = 0;

            for (int i = 0; i < salary.Length; i++){
                if(salary[i] > max) max = salary[i];
                else if (salary[i] < min) min = salary[i];

                sum += salary[i];
            }

            return (double) (sum - max - min) / (salary.Length-2);
    }
}