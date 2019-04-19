using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Collections;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        int[] B = A;
        int[] result = new int[N];
        
        if (A.Length == 0) {
            return result;
        }
        
        for(int i = 0; i < A.Length; i++) {
            
            if(A[i] >= 1 && A[i] <= N) {
                result[B[i] - 1] += 1;
            }
            
            else if(B[i] == N + 1) {
                
                int maxInt = result.Max();
                
                for(int j = 0; j < result.Length; j++) {
                    result[j] = maxInt;   
                }
                
            }
        }
        
        return result;
        
    }
    
}
