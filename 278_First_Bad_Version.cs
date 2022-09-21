/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) 
    {
        int bad = 0;
        int low = 1;
        int high = n;
        
        // It traverses all series
        while( low <= high )
        {
            // It takes middle unit for tests
            int mid = low + ( high - low ) / 2;
            // If it is bad, it starts again from 1 and goes to before it.
            if( IsBadVersion( mid ) )
            {
                bad = mid;
                high = mid - 1;                
            }
            // If it is not, it starts from after it and goes to n.
            else
                low = mid + 1;
        }
        
        return bad;
    }
}
