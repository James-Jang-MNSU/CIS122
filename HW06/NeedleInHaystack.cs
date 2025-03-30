public class Solution {
    public int StrStr(string haystack, string needle) {
        int repeat = haystack.Length - needle.Length + 1;
        for(int i=0; i<repeat; i++)
        {
            if(haystack.Substring(i,needle.Length) == needle)
            {
                return i;
            }
        }
        return -1;
    }
}