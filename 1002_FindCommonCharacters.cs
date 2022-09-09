public class Solution 
{
    public IList<string> CommonChars(string[] words) 
    {
        List<char> commonChars = new List <char>(); // Stores common characters
        List<char> tempList = new List<char>(); 
        List<string> result = new List<string>();

        // Adds first word to reference
        commonChars.AddRange(words[0]);

        // Traverse all words
        for ( int i = 0 ; i < words.Length ; i++ )
        {
            // Traverse all chars
            foreach ( var w in words[i] )
            {
                if ( commonChars.Contains( w ))
                {
                    tempList.Add(w); // Stores common characters temporarily
					commonChars.Remove(w); // We remove contained char for the retain from unintended results 
                }
            }
			commonChars.Clear(); // Clears all characters to get rid of extra characters in the list. (Second "o")
            
			commonChars.AddRange(tempList); // Adds true common characters
			tempList.Clear(); // Clears temporary list
        }

        // Iterates for the intended string list result
        foreach ( var c in commonChars)
        {
            result.Add(c.ToString());
        }
        
        return result;
    }
}
