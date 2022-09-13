public class Solution {
    public int Search(int[] nums, int target) 
    {
        int start = 0;
        int end = nums.Length - 1;
        
        // It traverses all array
        while ( start <= end )
        {
            // Traverses start to middle
            if( nums[start] == target )
                return start;
            // Traverses end to middle
            else if ( nums[end] == target )
                return end;

            start++;
            end--;
        }
        // If not finds returns -1
        return -1;
    }
}
