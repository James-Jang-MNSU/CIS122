public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int valCount = 0;
        int nonValCount = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == val)
            {
                valCount++;   
                nums[i] = 0;   
            }
            else
            {
                nonValCount++;
                nums[nonValCount-1] = nums[i];
            }
        }
        return valCount;
    }
}