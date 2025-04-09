public class Solution {
    public char FindTheDifference(string s, string t) {
        List<char> tToList = new List<char>();
        for(int i = 0; i<t.Length; i++)
        {
            tToList.Add(t[i]);
        }
        for(int j = 0; j<s.Length; j++)
        {
            tToList.Remove(s[j]);
        }
        return tToList[0];
    }
}