class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] B = new int[A.Length];
        
        int index = 0;
        for(int i = 0; i < B.Length; i++) {
            int k = i;
            for(int j = 0; j < K; j++) {
                index++;
                if(B.Length - 1 < index + k) {
                    k = 0;
                }
                else {
                    k = k + index;
                }
                index = 0;
            }
            B[k] =A[i];
        }
        
        return B;
    }
}
