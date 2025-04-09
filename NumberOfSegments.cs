public class Solution {
    public int CountSegments(string s) {
        int segmentCount = 0;
        bool inWord = false;
        for(int i = 0; i < s.Length; i++)
        {
            if(inWord && s[i] == ' ')
            {
                inWord = false;
                segmentCount++;
            }
            else if(inWord == false && s[i] != ' ')
            {
                inWord = true;
            }
        }
        if(inWord) 
        { 
            segmentCount++; 
        }
        return segmentCount;
    }
}