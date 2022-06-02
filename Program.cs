using System;
using System.Linq;
namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums={1,2,3,4};
            
            //for (int i=1;i<nums.Length; ++i){
               // nums[i]+=nums[i-1];
                
            //}
            
            //136. Single Number
            /*
            Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.
            */
            int [] nums={2,2,1};
            int result = 0;
        for(int i = 0; i < nums.Length; i++){
            result ^= nums[i];
        }
        Console.WriteLine(result);


            
        }
    }
}
