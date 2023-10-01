using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



namespace DataStructures.Using_Lists
{
    public class ListTester
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2, 3, 4, 6 };
            Console.WriteLine("First test");
            nums.Add(7);
            nums.Insert(2, 5); //Inserts the integer 5 at index 2 of the nums list, shifting the subsequent elements to the right.
            feaculMatter(nums); //Calls a function named feaculMatter and passes the nums list to it.
            Console.WriteLine("Second test");



            nums.Insert(0, 1); //Inserts the integer 1 at index 0 of the nums list, pushing the existing elements to the right.
            feaculMatter(nums);




            Console.WriteLine("Third test");
            nums.RemoveAt(nums.Count - 2); //Removes the element at the second-to-last index (index Count - 2) from the nums list.
            feaculMatter(nums);
            Console.WriteLine("Sum :" + SumOf(nums)); //Calls a function named SumOf with the nums list as an argument and prints the sum of its elements.



            Console.WriteLine("Does the number 4 exist = " + Exists(nums, 4)); //Calls a function named Exists to check if the number 4 exists in the nums list and prints the result.
            Console.WriteLine("The sum of all even" + SumsAllEven(nums)); //Calls a function named OddAvarage with the nums list as an argument. This function likely calculates and performs an operation related to odd numbers in the list, although the implementation is not shown.
            OddAvarage(nums);
            MultiplesOfThree(nums);
            Console.ReadLine();
        }



        public static int SumOf(List<int> nums)
        {



            int result = 0;
            result = nums.Sum();
            return result;
        }
        public static void feaculMatter(List<int> nums)
        {
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }



        public static bool Exists(List<int> nums, int x)
        {
            return nums.Contains(x);
        }



        public static double SumsAllEven(List<int> nums)
        {
            double result = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result += nums[i];
                }
            }
            return result;
        }
        public static void OddAvarage(List<int> nums)
        {
            int odds = 0;
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    odds += 1;
                    sum += nums[i];
                }
            }
            int avg = sum / odds;
            Console.WriteLine("Avarage of odd " + avg);




        }



        public static void MultiplesOfThree(List<int> nums)
        {
            foreach (int item in nums)
            {
                if (item % 3 == 0)
                {
                    Console.Write(item + ", ");
                }
            }

        }



        static string CheckNum(int x)
        {

            return x % 2 == 0 ? "even" : x % 3 == 0 ? "Multipe of three" : "Odd";
        }




        static bool CheckNum2(int x)
        {

            return x % 2 == 0;
        }




    }
}