import java.util.ArrayList;

class Solution {
    public int solution(int N) {
        String bin;
        bin = Integer.toBinaryString(N);
        ArrayList<Integer> results = new ArrayList<Integer>();
        int count = 0;
        int max = 0;      
      
        for (int i = 0; i < bin.length(); i++) {
            if(bin.charAt(i) == '1') {
                int j = i + 1;
                while(j < bin.length() && bin.charAt(j) == '0') {
                    count++;
                    if(j + 1 < bin.length() && bin.charAt(j + 1) == '1') {
                        results.add(count);
                        count = 0;
                        break;
                    }
                    j++;
                }
            }
        }
        if (results.isEmpty()) {
            return 0;
        }
        else {
            for(int i : results) {
                if (i > max) {
                    max = i;
                }
            }
            return max;
        }
    }
}
