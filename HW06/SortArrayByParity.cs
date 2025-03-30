public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int evenCount = 0;
        int oddCount = 0;
        int[] newArray = new int[nums.Length];
        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i] % 2 == 0)
            {
                newArray[evenCount] = nums[i];
                evenCount++;
            }
            else
            {
                newArray[nums.Length-1-oddCount] = nums[i];
                oddCount++;
            }
        }
        return newArray;
    }
}