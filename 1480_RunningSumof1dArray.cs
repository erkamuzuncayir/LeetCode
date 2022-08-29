public class Solution {
    public int[] RunningSum(int[] nums) {
        
        // Creates an array and variables for solutions.
        int[] sumOfNumber = new int[ nums.Length ];
        int sum = 0;
        int temp = 0;
        
        // Creates a for loop to calculate sum of array's numbers.
        for ( int i = 0 ; i < nums.Length ; i++ )
        {
            temp = nums[ i ];
            sum += temp;
            sumOfNumber[ i ] = sum;
        }
        
        // Returns result
        return ( sumOfNumber );
    }
}
