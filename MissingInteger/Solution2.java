class Solution {
    public int solution(int[] A) {
        
        int holder = 0;
        int result = 0;
        for(int i = 0; i < A.length; i++) {
            for(int j = i + 1; j < A.length; j++) {
                if (A[i] > A[j]) {
                    holder = A[i];
                    A[i] = A[j];
                    A[j] = holder;
                }
            }
        }
        
        for (int i = 0; i < A.length; i+=2) {
            if (i+1 < A.length && A[i] != A[i + 1]) {
                result = A[i];
                break;
            }
        }
        
        if(result == 0) {
            result = A[A.length - 1];
        }
        
        return result;
    }
}
