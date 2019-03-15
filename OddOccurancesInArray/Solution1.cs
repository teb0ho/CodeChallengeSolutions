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
        
        List<int> B = A.ToList();
        B = B.OrderBy(p => p).ToList();
        int ans = 0;
        foreach(int items in B) {
            int count = 0;
            foreach(int item in B) {
                if(items == item) {
                    count++;
                }
            }
            
            if (count == 1) {
                ans = items;
                break;
            } 
        }
        return ans;
    }
}
