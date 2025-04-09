public class Solution 
{
    public string MergeAlternately(string word1, string word2) {
        int index = 0;
        string mergedWord = "";
        while(index < word1.Length || index < word2.Length)
        {
            if(index < word1.Length) mergedWord += word1[index];
            if(index < word2.Length) mergedWord += word2[index];
            index++;
        }
        return mergedWord;
    }
}