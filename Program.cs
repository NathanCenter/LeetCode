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
            /*
            int[] nums1 = { 1,2,3,0,0,0 };
        int item = 0;
       int[] nums2 = {2,5,6};
 
        nums1 = nums1.Where(e => e != item).ToArray();
      
        int [] combine=nums1.Concat(nums2).ToArray();
        Console.WriteLine(String.Join(",",combine));
            */ 

            //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
            
            /*
              int[] nums = { 1,2,3,1 };

            for(int i=0; i< nums.length; i++){
                for(int j=i+1; j<nums.length; i++){
                        if(nums[i]==nums[j])
                        {
                            Console.WriteLine("true");
                        }
                        else{
                            Console.WriteLine("False");
                        }

                }
            */
            /*
            Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.
            */
            /*string num1="110000000";
            string num2="155555553";
            int result1=Int32.Parse(num1);
            int result2=Int32.Parse(num2);
            int sum=result1+result2;
            string convert=sum.ToString();
            Console.WriteLine(convert);
            
            }*/

            /*
            Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.*/
            /*int [] numbers={1,2,3};
            if (numbers.Length !=numbers.Distinct().Count()){
               Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            } */

            /*
            You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".
            Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
            */
         string jewels="aA";
         string stones="aAAbbb";
         char has='A';

         int count1=jewels.Count(p=>p==has);
         int count2=stones.Count(p=>p==has);
         int total=count1+count2;
         string  Convert=total.ToString();
        Console.WriteLine(Convert);


    }
}
}

