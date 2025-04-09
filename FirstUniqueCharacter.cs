public class Solution {
    public int FirstUniqChar(string s) 
    {
        Dictionary<char, int> uniqCharDict = new Dictionary<char, int>();
        List<char> alreadyChecked = new List<char>();
        for(int i=0; i<s.Length; i++)
        {
            if(uniqCharDict.Keys.Contains(s[i]))
            {
                if(!alreadyChecked.Contains(s[i]))
                {
                    alreadyChecked.Add(s[i]);
                    uniqCharDict.Remove(s[i]);
                }
            }
            else if(!alreadyChecked.Contains(s[i]))
            {
                uniqCharDict.Add(s[i], i);
            }
        }
        if(uniqCharDict.Keys.Count == 0) return -1;
        return uniqCharDict.Values.Min();
    }
}