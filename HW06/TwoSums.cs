public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {        
        for(int i=0; i < nums.Length-1; i++)
        {
            int remainder = target - nums[i];
            for(int j=i+1; j < nums.Length; j++)
            {
                if (remainder == nums[j])
                {
                    return [i,j];
                }
            }
        }
        // To avoid error saying, "not all code paths return a value"
        // Justified because the problem said each input is guaranteed to have one solution
        return [0,0];
    }
    
}