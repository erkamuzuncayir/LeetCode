public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // Creates an array and variables for solution
        int[] numberArray = new int[ 2 ];
        int targetNumber = target;
        int checker = 0;
        
        // Creates an for loop to iterates numbers and sums
        for( int i = 0; i < nums.Length ; i++ )
        {
            for( int j = 0; j < nums.Length ; j++ )
            {
                if( i != j )
                    checker = nums[ i ] + nums[ j ];
                if ( checker == targetNumber )
                {
                    numberArray[ 0 ] = i;
                    numberArray[ 1 ] = j;
                    Array.Sort( numberArray );
                    break;
                }
            }
        }
        
        // Returns result
        return numberArray;
    }
}
