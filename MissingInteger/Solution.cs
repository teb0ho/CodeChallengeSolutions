using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int max = A.Max();
        int min = A.Min();
        int result = 0;
        
        
        for(int i = 1; i <= max; i++) {
            if(!A.Contains(i)) {
                result = i;
                break;
            }    
        }
        
        if(max < 0) {
            return 1;
        }
        
        if(result == 0) {
            return max + 1;
        }
        
        return result;
    }
}
