using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int minimumDifference = 0;
        int split = 0;
        int left = 0; 
        int right = 0;
        List<int> results = new List<int>();
        while(split < A.Length - 1) {
            
            for (int j = 0; j < A.Length; j ++) {
                if (j <= split) {
                    left += A[j];
                }
                else {
                    break;
                }
            }
            
            
            
            for(int i = 1; i < A.Length; i++) {
                if(i > split) {
                    right += A[i];
                }        
            }
            results.Add(Math.Abs(left - right));
            left = 0;
            right = 0;
            split++;
        }
        
        return results.OrderBy(p => p).First();
    }
}
