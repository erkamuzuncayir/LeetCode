public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        // Creates lists with strings to check them easily
        List< char > ransomNoteList = ransomNote.ToList();
        List< char > magazineList = magazine.ToList();
        
        // Creates boolean variable for result
        bool isContain = true;
        
        // Iterates foreach loop to traverse all chars within ransomNote
        foreach (var r in ransomNoteList)
        {
            // If magazine contain a char, it removes it so as not use the same char twice.
            if( magazineList.Contains(r) )
                magazineList.Remove(r);
            else
                isContain = false;
        }        
            return isContain;
    }
}
