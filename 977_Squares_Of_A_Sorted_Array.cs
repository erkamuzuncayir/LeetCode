public class Solution {
    public int[] SortedSquares(int[] nums) 
    {
        int left = 0 , right = nums.Length - 1 , count = nums.Length;
        
        int[] sortedSquares = new int[ nums.Length ];
        
        // Traverses array
        while( count > 0 )
        {
            count--;
            
            // Takes squares
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];
            
            // If left one bigger than right one, assign left one to right's place.
            if( leftSquare > rightSquare )
            {
                sortedSquares[ count ] = leftSquare;
                left++; // Increment ordinal
            }
            // If right one bigger than left one, assign right one to left's place.
            else
            {
                sortedSquares[ count ] = rightSquare;
                right--; // Decrement ordinal
            }
            
        }
        
        return sortedSquares;
    }
}
