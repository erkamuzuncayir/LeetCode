public class Solution {
    public int SearchInsert(int[] nums, int target) 
    {
        int low = 0;
        int high = nums.Length - 1;
        int num = 0;
        
        // It traverses all series
        while( low <= high )
        {
            // It takes middle unit for tests
            num = low + ( high - low ) / 2;
            
            // If it is the number, returns
            if( target == nums[ num ] )
                return num;

            // If it is less than taken number, shrink size
            else if( target < nums[ num ])
                high = num - 1;

            // If it is more than taken number, shrink size
            else
                low = num + 1;
        }
        
        /* 
            If it can't find the number, it returns low variable, 
            because if it is not here it should have been place where last piece what it looking for.
        */
        return low;
    }
}
