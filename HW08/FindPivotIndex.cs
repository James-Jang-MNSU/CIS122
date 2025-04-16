public class Solution {
    public int PivotIndex(int[] nums) {
        int totalSum = 0;
        foreach(int x in nums)
        {
            totalSum += x;
        }

        if (totalSum - nums[0] == 0) return 0;
        int lSum = 0;
        for(int i = 1; i<nums.Length; i++)
        {
            lSum += nums[i-1];
            if(lSum * 2 == totalSum - nums[i]) return i;
        }
        return -1;
    }
}