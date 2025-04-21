public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        int maxNum = -1;
        int maxFrequency = 0;
        for(int i = 0; i<nums.Length; i++)
        {
            int x = nums[i];
            if(frequencies.ContainsKey(x))
            {
                frequencies[x]++;
            }
            else
            {
                frequencies.Add(x,1);
            }
            if(frequencies[x] > maxFrequency)
            {
                maxNum = x;
                maxFrequency = frequencies[x];
            }
        }
        return maxNum;        
    }
}