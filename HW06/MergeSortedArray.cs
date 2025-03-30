public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        if(m == 0)
        {
            for(int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = nums2[i];
            }
        }
        else
        {
            int nums1Index = m-1;
            int nums2Index = n-1;
            for(int i = nums1.Length-1; i > -1; i--)
            {
                if(nums1Index >= 0 && nums2Index >= 0)
                {
                    if(nums2[nums2Index] > nums1[nums1Index])
                    {
                        nums1[i] = nums2[nums2Index];
                        nums2Index--;
                    }
                    else
                    {
                        nums1[i] = nums1[nums1Index];
                        nums1Index--;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}