using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Collections;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if(A.Length == 1) {
            return A[0] == 1 ? 1 : 0;
        }
        int max = A.Max();
        int count = 0;
        int countB = 0;
        List<int> B = A.ToList();
        while(max > 0) {
            
            bool duplicate = B.Count(x => x == max) > 1;
            if(B.Contains(max) && !duplicate) {
                count++;
            }
            countB++;
            max--;
        }
        
        return count == countB ? 1 : 0;
    }
}
