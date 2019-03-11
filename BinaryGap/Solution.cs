using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        string binary = Convert.ToString(N, 2);
        List<int> results = new List<int>();
        int oneIndicator = 0;
        int max = 0;
        int count = 0;
        for(int i = 0; i < binary.Length; i++) {
            if(binary[i] == '1') {
                oneIndicator += 1;
            }
            
            if(oneIndicator == 1 && binary[i] == '0') {
                count++;
            }
            
            if(oneIndicator == 2) {
                oneIndicator = 1;
                results.Add(count);
                count = 0;
            }
        }
        
        if (results.Count == 0) {
            return 0;     
        }
        else {
            foreach(int i in results) {
                if(i > max) {
                    max = i;
                }
            }
            
            return max;
        }
    }
}
