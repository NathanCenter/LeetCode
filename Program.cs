using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums={1,2,3,4};
            
            for (int i=1;i<nums.Length; ++i){
                nums[i]+=nums[i-1];
                
            }
            
        }
    }
}
