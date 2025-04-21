public class Solution {
    public void MoveZeroes(int[] nums) {
        int nonZero = 0;
        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                nums[nonZero] = nums[i];
                nonZero++;
            }
        }
        for(int j = nonZero; j<nums.Length; j++)
        {
            nums[j] = 0;
        }
    }
}