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
        
        return (int)B.GroupBy(p => p).Select(p => new { Number = p.Key, Count = p.Count() }).Where(p => p.Count == 1).Select(p => p.Number).First();
        
       // return B[0];
    }
}
