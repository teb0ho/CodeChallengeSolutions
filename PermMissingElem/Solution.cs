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
            if(A.Length == 0) {
                return 1;
            }
        
            if(A.Length == 1) {
                if(A[0] - 1 >= 1) {
                    return A[0] - 1;
                }
                else {
                    return A[0] + 1;
                }
            }
        
            List<int> Ordered = A.OrderBy(p => p).ToList();
        
            int max = Ordered[Ordered.Count - 1] ;
            int answer = 0;
            while ( max > 0) {
                if(!Ordered.Contains(max)) {
                    answer = max;
                    break;
                }
                max--;
            }
        
            if(answer < 1) {
                return Ordered[Ordered.Count - 1] + 1;
            }
            else {
                return answer;
            }
        }
    }
