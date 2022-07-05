using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            /*
               string jewels="aA";
         string stones="aAAbbb";
         char has='A';

         int count1=jewels.Count(p=>p==has);
         int count2=stones.Count(p=>p==has);
         int total=count1+count2;
         string  Convert=total.ToString();
        Console.WriteLine(Convert);

            */

            /*
         C# program to find sum of array elements
            */
          
           /*
           int [] sumAll={10,20,50,-100,-52,30,-10};
              int sum=0;
              foreach(int item in sumAll){
                   sum+=item; 

              }
              Console.WriteLine("Sum of all arrays "+sum);
           */

           /* C# program to count negative elements in array*/
        /*
                int [] allArrays={-1,23,-4,9,-1};
         int  negative;
Console.WriteLine("List of negative numbers: ");
         foreach(int number in allArrays){
             if (number<0){
                 negative=number;
                Console.WriteLine(negative);
             }
            
            
         }
        */
 
 /*
 Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
 */

 /*
  List <Int32> head=new List<Int32>();
    head.Add(1);
    head.Add(2);
    head.Add(3);
    head.Add(4);
    head.Add(4);
    int val=4;
    head.RemoveAll(x=>x==val);

        foreach (int a in head)
        Console.WriteLine(a);

 */

 /*Given a non-negative integer x, compute and return the square root of x.

Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.

*/
  
  /*
int x=8;
double answer=Math.Sqrt(x);

double roundUp=Math.Ceiling(answer);

Console.WriteLine(roundUp);

    }
    */

    /*We define the usage of capitals in a word to be right when one of the following cases holds:

    All letters in this word are capitals, like "USA".
    All letters in this word are not capitals, like "leetcode".
    Only the first letter in this word is capital, like "Google".

Given a string word, return true if the usage of capitals in it is right.*/

/*
string word="usA";

char [] charArry=word.ToCharArray();

foreach(char convert in charArry){

bool b=Char.IsUpper(convert);
   Console.WriteLine(b);
}
   
*/
/*
Write C# Program to print day name of week. 
*/
/*
Console.WriteLine("Enter a number that will print out a day in the week");
   
   int week=Convert.ToInt32(Console.ReadLine());
    if (week==1){
        Console.WriteLine("Monday");
    }
   else if (week==2){
        Console.WriteLine("Tuesday");
    }
   else if (week==3){
        Console.WriteLine("Wednesday");
    }
   else if (week==4){
        Console.WriteLine("Thursday");
    }
   else if (week==5){
        Console.WriteLine("Friday");
    }
   else if (week==6){
        Console.WriteLine("Saturday");
    }
   else if (week==7){
        Console.WriteLine("Sunday");
    }
    else
        {
            Console.WriteLine("Invalid Input! Please enter week in between 1-7.");
        }

}
*/

/*convert a int to a roman numerals */
/*
int num=3;
switch(num) 
{
case 1:
    Console.WriteLine("I");
break;
case 2:
 Console.WriteLine("II");
break;
case 3:
 Console.WriteLine("III");
break;
default:
    Console.WriteLine("please enter a number that is not a negative number or zero");
break;
}

*/
/*convert a string into a number and display it in the console*/
/*

string x="25";
string y="23";
int number1=Int32.Parse(x);
int number2=Int32.Parse(y);
int total=number1+number2;
Console.WriteLine(total);
*/

/*
Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

You can use each character in text at most once. Return the maximum number of instances that can be formed.
*/
/*
string text="balloon";
 int b = 0, a = 0, n = 0, o = 0, l = 0;
        foreach(var c in text){
            if(c == 'b')
                b++;
            else if(c == 'a')
                a++;
            else if(c == 'n')
                n++;
            else if(c == 'o')
                o++;
            else if(c == 'l')
                l++;
        }

        return Math.Min(b, Math.Min(a, Math.Min(n, Math.Min(o/2, l/2))));

*/

/*
Given an array a , n print the reverse of it.
const int n=4;
int [] A= new int[n]{1,2,3,4};
Array.Reverse(A);
Console.WriteLine(String.Join(',',A));
*/

/*
You are given a string s formed by digits and '#'. We want to map s to English lowercase characters as follows:

    Characters ('a' to 'i') are represented by ('1' to '9') respectively.
    Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.
    
string s="10#11#12";
string replace=s.Replace("10#","j").Replace("11#","k").Replace("1","a").Replace("2","b");

Console.WriteLine(replace);

*/
/*
Search even numbers in an array
int [] allNumbers={3,5,2,4,3,1,8,10,6,4};

for (int i=0;i<allNumbers.Length;i++){
        if ((allNumbers[i]%2)==0){
            Console.WriteLine(allNumbers[i]);
        }
*/
/*
A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself. A divisor of an integer x is an integer that can divide x evenly.

Given an integer n, return true if n is a perfect number, otherwise return false.
int num=7;
        if ((num/1)==28||(num/2)==14 ){
            Console.WriteLine("true");
        }
        else{
            Console.WriteLine("false");
        }
*/
        

/*Write C# program to reverse a number
Console.WriteLine("please write your number");
int forwardNumber=Int32.Parse(Console.ReadLine());

int reverse=0;

while(forwardNumber != 0){
reverse = reverse * 10;
reverse = reverse + forwardNumber % 10;
forwardNumber = forwardNumber / 10;
}
Console.WriteLine(reverse);

*/
/*
Given two binary strings a and b, return their sum as a binary string.
string a="11";
string b="1";

int convert1=Convert.ToInt32(a,2);
int convert2=Convert.ToInt32(b,2);
int totalNumbers=convert1+convert2;

string convertTotal=Convert.ToString(totalNumbers,2);
Console.WriteLine(convertTotal);
*/

/*
Unique Email Addresses
string[] emails={"ali.ce.z@leetcode.com","my@email.com"};
    if(emails.Length==1) return 1;
        HashSet<string> es = new HashSet<string>();
        
        foreach(var email in emails)
        {
            var str = email.Split('@');
            string ps = str[0].Split('+')[0];
            es.Add(string.Concat(ps.Split('.')) + '@' + str[1]);
        }
        
        return es.Count();
*/

/*Given an array nums of integers, return how many of them contain an even number of digits.

int [] nums={12,345,2,6,7896};

foreach(int i in nums){
    int count=i.ToString().Length;
   if (count%2==0){
    Console.WriteLine("even");
   }
   else{
    Console.WriteLine("odd"); 
    
   }


}
*/

/*This C# Program Calculates Power of Three.
Console.WriteLine("Please type in the number that you want to calulate the power of 3");
double userNumber=Convert.ToDouble(Console.ReadLine());
double powerOf3=Math.Pow(userNumber,3);

Console.WriteLine(powerOf3);
 */

 /*
 
    User provides their name as Input and then application show message to "Welcome to their Name".
    Jack, Steven and Mathew are banned for the organization. So, when any user enters Jack, Steven and Mathew as user name, the application raised an event and fire alarm as well as sends email to administration.
 Console.WriteLine("Please enter your name");
 string userName=Console.ReadLine();
 if(userName=="Jack"|| userName=="jack"){
    Console.WriteLine("Sorry Jack you are banned from the organization. Sending email to the administrater");
 }
 else if(userName=="Steven"|| userName=="steven"){

 Console.WriteLine("Sorry Steven you are banned from the organization. Sending email to the administrater");
 }
 else if (userName=="Mathew"|| userName=="mathew"){

Console.WriteLine("Sorry Mathew you are banned from the organization. Sending email to the administrater");
 }
 else{
     Console.WriteLine("Welcome to "+ userName);
 }
 */

 /*
 You are given an integer array score of size n, where score[i] is the score of the ith athlete in a competition. All the scores are guaranteed to be unique.

The athletes are placed based on their scores, where the 1st place athlete has the highest score, the 2nd place athlete has the 2nd highest score, and so on. The placement of each athlete determines their rank:
 
 int [] score={5,4,3,2,1};

 Array.Sort(score);

foreach(int order in score){
        if (order==1){
            Console.WriteLine("Gold Medal");

        }
        else if (order == 2){
             Console.WriteLine("Silver Medal");
        }
        else if (order ==3){
            Console.WriteLine("Bronze Medal");
        }
        else if (order== 4){
            Console.WriteLine(4);
        }
        else if (order ==5){
            Console.WriteLine(5);
        }
   
}
 */

/*
Given a year as integer, write a method that checks if year is leap.
*/

Console.WriteLine("Type in year");
int year=Int32.Parse( Console.ReadLine());
if(year%4==0 && year % 100 != 0 || year % 400 == 0){
    Console.WriteLine("this is a leap year");


}
else{
    Console.WriteLine("this is not a leap year");
}
//Console.WriteLine(year);

}
}
}
