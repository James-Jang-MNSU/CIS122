public class Solution {
    public int LengthOfLastWord(string s) {
        int wordLength = 0;
        bool inWord = false;
        for(int i = s.Length-1; i>=0; i--)
        {
            if(!inWord && s[i] != ' ')
            {
                inWord = true;
                wordLength++;
            }
            else if(inWord && s[i] != ' ')
            {
                wordLength++;
            }
            else if(inWord && s[i] == ' ')
            {
                return wordLength;
            }
        }
        return wordLength;
    }
}