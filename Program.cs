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
           
           int [] nums={2,2,1};
            int result = 0;
        for(int i = 0; i < nums.Length; i++){
            result ^= nums[i];
        }
        Console.WriteLine(result);

            */

            /*
            You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
            */
             int[] nums1 = { 1,2,3,0,0,0 };
        int item = 0;
       int[] nums2 = {2,5,6};
 
        nums1 = nums1.Where(e => e != item).ToArray();
        //Console.WriteLine(String.Join(",", nums1));
        int [] combine=nums1.Concat(nums2).ToArray();
        Console.WriteLine(String.Join(",",combine));
            
        }
    }
}
