public class Solution {
    public bool ValidPalindrome(string s) 
    {
        int start = 0;
        int end = s.Length - 1;
        
        // Traverses start to end. If word already palindrome, returns true
        while ( start < end )
        {
            // If chars matches, shrink the search space both side.
            if ( s[start] == s[end])
            {
                start++;
                end--;
            }
            /*  If word not palindrome, 
                We traverse word with one more char from front or one less char from end
            */
                else
            {
                if( isPalindrome( s , start + 1 , end ) ) 
                    return true;
                if( isPalindrome( s , start , end -1 ) )
                    return true;
                
                return false;
            }
        }
        
        return true;
    }
    
    public bool isPalindrome( string s , int start , int end )
    {
        // If chars matches, shrink the search space both side.
        while ( start < end )
        {
            if( s[start] == s[end] )
            {
                start++;
                end--;
            }
            // If not, returns false
            else
                return false;
        }
        
        return true;
    }
        
}
