import java.util.ArrayList;

class Solution {
    public int solution(int N) {
    
        String binaryS = Integer.toBinaryString(N);
        int count = 1;
        ArrayList<Integer> counts = new ArrayList<Integer>();
        for(int i = 0; i < binaryS.length(); i++) {
            if(binaryS.charAt(i) == '0' && count > 0) {
                count += 1;
            }
            else if(count > 1 && binaryS.charAt(i) == '1') {
                counts.add(count);
                count = 1;
            }
            else {
                count = 1;
            } 
                
        }
        
        for(int i : counts) {
            if(i > count) {
                count = i;
            }
        }
        
        return count - 1;
        
    }
}
