public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        // Creates variables
        int sum = 0;
        int max = 0;
        
        // Creates nested loops, therefore we can compare all customers account's.
        for ( int i = 0 ; i < accounts.Length ; i++ )
        {
            
            sum = 0;
            
            for ( int j = 0 ; j < accounts[i].Length ; j++ )
            {
                
                sum += accounts[i][j];
                
                if ( sum > max ) // Stores max number
                    max = sum;

            }
        }
        
        return max;
        
    }
}
