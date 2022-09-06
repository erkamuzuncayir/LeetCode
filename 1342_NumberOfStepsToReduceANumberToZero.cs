public class Solution {
    public int NumberOfSteps(int num) 
    {
        int count = 0;
        while ( num > 0 )
        {
            if ( num % 2 != 0 )
            {
                num -= 1;
                count++;
                continue;
            }
            num /= 2;
            count++;
        }
        return count;
    }
}
