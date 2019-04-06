using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Collections;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        bool[] steps = new bool[X];
        int result = -1;
        
        if(A.Length == 1) {
            if(X == A[0]) {
                return 0;
            }
            else {
                return result;
            }
        }
        
        if(A.Length < X) {
            return result;
        }
        
        for(int i = 0; i < A.Length; i++) {
            if(A[i] <= X && steps[A[i] - 1] == false) {
                steps[A[i] - 1] = true;
            }
            if(checkIfPathWayIsComplete(steps)) {
                result = i;    
                break;
            }
        }
        
        return result;
        
    }
    
    public bool checkIfPathWayIsComplete(bool[] A) {
        bool result = true;
        for(int i = 0; i < A.Length; i++) {
            if(A[i] == false) {
               result = false;
               break;
            }
        }
        return result;
    }
}
