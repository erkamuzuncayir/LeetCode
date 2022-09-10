public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) 
    {
        int wholeRoad = 0;
        int firstPath = 0;
        
        // Calculates whole distance.
        for ( int i = 0 ; i < distance.Length ; i++ )
        {
            wholeRoad += distance[ i ];
        }
        
        // Checks whetheter start or destination is bigger
        if ( start < destination )
        {            
            // Calculates clockwise path
            for ( int j = start ; j < destination ; j++ )
                firstPath += distance[ j ];
        }
        
        else
        {
            // Calculates counterclockwise path
            for ( int k = start - 1 ; k >= destination ; k-- )
                firstPath += distance[ k ];
        }
        
        // Calculates alternative path
        int secondPath = wholeRoad - firstPath;

        // Returns smaller value.
        if ( firstPath < secondPath )
            return firstPath;
        else
            return secondPath;

    }
}
