class Solution {
    public int solution(int[] A) {
        int result = 0;
        
        boolean ars[] = new boolean[A.length];
        
        for(int i = 0; i < A.length; i++) {
            if(A[i] > 0 && A[i] <= A.length)
                ars[A[i] - 1] = true;
        }
        
        result = A.length + 1;
        
        for(int i = 0; i < A.length; i++) { 
            if(ars[i] == false) {
                result = i + 1;
                break;
            }
            
        }
        
        return result;
        
    }
}
