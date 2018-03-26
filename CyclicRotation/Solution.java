class Solution {
    public int[] solution(int[] A, int K) {
        int B[] = new int[A.length];

        for(int i = 0; i < A.length; i++) {
            int indexInBound = 0;
            if(i + K > A.length - 1) {
                indexInBound = (i + K) - A.length;

                while(indexInBound >= A.length) {
                    indexInBound = indexInBound - A.length;
                }

                B[indexInBound] = A[i];
            }
            else {
                indexInBound = i + K;
                B[indexInBound] = A[i];
            }
        }

        return B;
    }

}
