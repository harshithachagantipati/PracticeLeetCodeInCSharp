using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramPreps
{
    class Practice
    {
        public void test()
        {
            Console.WriteLine("Hi this is Practice code.. Main method is in Program");
        }
        public string reverseString(string s)
        {
            string reversename = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversename += s[i];
            }
            Console.WriteLine("Reverse Name: " + reversename);
            return reversename;
        }
        //leetcode 344 reverse of Array of char string Input: s = ["h","e","l","l","o"] Output: ["o", "l", "l", "e", "h"]
        public void reverseStringArrayChars(char[] s)
        {
            int left = 0, right = s.Length - 1; ; //index for 2 pointer
            while (left < right) //left = 0, rght = 9, 0<9, 1<8, 2<7, 3<6,4<5,5<4 exit loop
            {
                char temp = s[left]; //temp = 0, left is empty, temp =1, 2,3,4
                s[left] = s[right]; //0 = 9, left = 9, left = 8,7,6,5
                s[right] = temp; // 9 = 0, right = 0, right = 1,2,3,4
                left++; //
                right--;
            }
        }
        //sum of natural numbers
        public void sumofNaturalNumbers(int n)
        {
            Console.WriteLine("Number is:" + n);
            int sumofnumbers = 0;
            for (int i = 1; i <= n; i++)
            {
                sumofnumbers += i;
            }
            Console.WriteLine($"Sum of {n} natural numbers are {sumofnumbers}");
            //adding even numbers
            int addeven = 0, addodd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    addeven += i;
                }
                else
                {
                    addodd += i;
                }
            }
            Console.WriteLine($"Adding Even Numbers in: {n} is {addeven}");

            Console.WriteLine($"Adding Odd Numbers in: {n} is {addodd}");
        }
        //multiplication table, range multiplication, 1x1=1, 1x2 = 2, 1x3 = 3,
        //                                            2x1=2, 2x2 = 4, 3x3 = 6
        //                                          ..8x1=8, 8x2 = 16,8x3 = 24 
        public void tableMultiplication(int n)
        {
            Console.WriteLine("Table number: " + n);
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"{i} x {j} = {j * i}");
                }
                Console.WriteLine();
            }
        }
        //remove duplicate chars in a string
        public void removeDuplicateChars(string n)
        {
            Console.WriteLine("Given Stiring: " + n);
            HashSet<char> chars = new HashSet<char>();
            StringBuilder sb = new StringBuilder();
            foreach (char c in n)
            {
                if (!chars.Contains(c))
                {
                    chars.Add(c);
                    sb.Append(c);
                }
            }
            Console.WriteLine("Result: " + sb.ToString());
        }
        //FizzBuzz problem with List 
        public IList<string> FizzBuzz(int n)
        {
            List<string> output = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    output.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    output.Add("Buzz");
                }
                else
                {
                    output.Add(i.ToString()); //Add number as a string
                }
            }
            return output;

        }
        //Reverse of number
        public int ReverseNumber(int n)
        {
            int sum =0 ;
            while(n !=0)
            {
                int rem = n % 10; // gets last digit
                n = n / 10; //removes last digit quotient
                sum = sum *10+ rem; //append to sum                
            }
            return sum;
        }
        //Decompress Run-Length Encoded List:https://leetcode.com/problems/decompress-run-length-encoded-list/ - Iterating through a list to expand encoded data.
        public int[] DecompressRunList(int[] n) //smitha 6 - 1,2,3,4,5,6
        {
            List<int> result = new List<int>();
            for (int i = 0; i < n.Length; i+=2) // 0,6,2,4 frequency for every 1st value in a 2 values so iterate after 1
            {
                int freq = n[i]; //index = value 0 = 1, 2 = 3, 4 = 5 freq = 1, 3
                int value = n[i+1]; // 1 = 2, 3= 4 , 5 = 6 value = 2, 4
                for (int j = 0; j < freq; j++) // 1, 4 for each frequency add next value
                {
                    result.Add(value); //add to list 2,4,4,4,
                }
            }
            return result.ToArray(); // Convert List to int[]
        }
        //leetcode 1342 number of steps take to make number to zero
        public int NumberOfSteps(int num) // 14
        {
            int count = 0;
            while(num > 0) // can use while(num != 0) 14 > 0, 7, 6, 3, 2, 1 
            {
                if(num % 2 == 0) // 14 % 2 = rem 0, quo = 7
                {
                    num /= 2; // 14/2 = quo 7
                }
                else { num -= 1; } // 7-1 = 6 make it even
                count++; // (14)1,(7)2,(6)3,(3)4,(2)5,(1)6
            }
            return count;
        }
        //leetcode 88 Merge sorted array nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        public void MergeSort(int[] nums1, int m, int[] nums2, int n)
        {
            int p = m + n - 1, p1 = m - 1, p2 = n - 1; //index values 0,1,2
            while(p1 >= 0 && p2 >= 0) //2,2 1,1 0,0
            {
                if (nums1[p1] >  nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
                p--;
            }
            while(p2 >= 0) // [], [1] index 0
            {
                nums1[p] = nums2[p2]; // value 1 in nums1 array
                p2--;
                p--;
            }
        }

        //leetcode - 80. Remove Duplicates from Sorted Array II Medium
        /*public int RemoveDuplicatesInArray2(int[] nums) //1, 2, 2,2,3, 4, 0, 0 
        {
            if (nums.Length <= 2)
            {
                return nums.Length;
            }
            int k = 2;
            for (int j = 2; j < nums.Length; j++) 
            { //[1,1,1,2,2,3]
                if (nums[j] != nums[k - 2]) //1, 2, 2,2,3, 4, 0, 0 - 2!=1 , 2!=2 no
                { //1 != 1, 2 != 1, 2 != 1
                    nums[k++] = nums[j]; //k++ is after the asigning of j : 1,1,2, 2 : - 1,2,2
                } // k = 3 k++ means K+1 2+1 is 3
            }
            return k;
        }*/

        public int RemoveDuplicatesInArray2(int[] nums)
        {
            if(nums.Length <= 0)
            {
                return nums.Length;
            }
            int k = 2;
            for(int j = 2; j < nums.Length; j++)
            {
                if (nums[j] != nums[k - 2])
                {
                    nums[k++] = nums[j];
                }
            }
            return k;
        }

        //leetcode169 : Majority Number
        public int MajorityElement(int[] nums)
        {
            int value = nums[0], count = 0;
            foreach (int num in nums)
            {
                if (count == 0)
                {
                    value = num;
                }
                //count += (num == value) ? 1 : -1;  //terinary operation
                //Above is terinary operation its 1 line code for below 8 lines of code 
                if (num == value) //1
                {//2
                    count++;
                }//4
                else //5
                {//6
                    count--;
                }//8
            }
            Console.WriteLine("Count : {0} and Value {1}",count,value);
            return value;
        }

        //189. Rotate Array - Medium
        public static void Rotate(int[] nums, int k)
        {
            // k = k % nums.Length;
            // var arr1 = nums.Skip(nums.Length - k); // 5,6,7
            // var arr2 = nums.Take(nums.Length - k); //1,2,3,4
            // int[] arr3 = arr1.Concat(arr2).ToArray(); //5,6,7,1,2,3,4
            // for(int i = 0; i < nums.Length; i++){
            //     nums[i] = arr3[i];
            // }
            //Above Runtime: 4 ms Beats 8.81% and 66 MB very high. so I wanna solve in less memory
            foreach (int num in nums){
                Console.WriteLine("Array Before rotate: " + num);
            }
            if (nums != null && nums.Length > 0 && k > 0)
            {
                k = k % nums.Length;
                Array.Reverse(nums); // Reverse entire array
                Helper(nums, 0, k - 1); // reverse array from 0 to k
                Helper(nums, k, nums.Length - 1); // Reverse the array from k to end of array
                foreach (int num in nums)
                {
                    Console.WriteLine("Array After rotate: " + num);
                }
            }
        }
        private static void Helper(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        // this Above Runtime 1 ms Beats 52.63%

        //121. Best Time to Buy and Sell Stock
        public static int MaxProfit(int[] prices)
        {
            int buyPrice = prices[0]; //7
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            { //foreach(int i in prices) {
                if (prices[i] < buyPrice)
                { //1
                    buyPrice = prices[i]; //1
                }
                else if (prices[i] - buyPrice > profit)
                { //1-1 = 0 no 5-1 4, 3-1 2, 6-1 5, 
                    profit = prices[i] - buyPrice; // 4, 5
                }
            }
            return profit; // 5
        }

        //leetcode : 380 Insert Delete GetRandom - use of list, dictionary, Random
        public class RandomsizedSet
        {
            private Dictionary<int, int> dict;
            private List<int> list;
            private Random rand;
            public RandomsizedSet()
            {
                dict = new Dictionary<int, int>();
                list = new List<int>();
                rand = new Random();
            }
            public bool Insert(int val) // 20, 10
            {
                if(dict.ContainsKey(val)) // if inserting 20, 10, 
                    return false;
                else
                    dict[val] = list.Count; // If list = [10, 20] (count = 2) if inserting 20 k0v20 20 = 0 k-0v-20, 10 = 1 k-1 v-10
                    list.Add(val); // 20 - 0 , 10 - 1
                    Console.WriteLine("In Dict value {0} and key ", dict[val]);
                    return true; //20 , 10
            }
            public bool Remove(int val) //10
            {
                if(!dict.ContainsKey(val)) return false; //10
                int index = dict[val]; // 10
                int lastIndex = list[list.Count - 1]; // 2 -1 = 1 list[1]
                list[index] = lastIndex; // bodmas - 10 = 10 
                dict[lastIndex] = index; // 10 = 10
                list.RemoveAt(list.Count - 1); // 2 - 1 = 1  // 10 remove 
                dict.Remove(val); // 10 
                return true ; // true
            }
            public int GetRandom()
            {
                int index = rand.Next(dict.Count);
                return list[index];
            }            
        }

        //238. Product of Array Except Self : Input: nums = [1, 2, 3, 4] Output: [24, 12, 8, 6] Input2:  nums = [-1,1,0,-3,3] Output2: [0, 0, 9, 0, 0]
        public static int[] ProductExceptSelf(int[] nums)
        {
            int nLength = nums.Length;
            int[] result = new int[nLength];
            //step1: Fill result with left product
            result[0] = 1; //1,1,2,6
            for (int i = 1; i < nLength; i++)
            { //1,2,3 < 4
                result[i] = result[i - 1] * nums[i - 1]; //1*1, 1*2, 2*3 [1,1,2,6] 
            }
            //step2: fill reult with right product
            int rightProduct = 1; //1,4,12,24
            for (int i = nLength - 1; i >= 0; i--)
            { //4-1 3 >=0, 2,1,0 >=0
                result[i] *= rightProduct; // result[3] = 6*1, 2 = 2*4, 1 = 1*12, 0 = 1*24 
                rightProduct *= nums[i]; // 1*4 = 4, 4*3 = 12, 12*2 = 24, 24*1 = 24
            }
            return result;
        }

        /*
                //working with members here I have class Practice 
                //YouTube C# 7 hrs couce 4: 53:37 Members topic using of destructor lets start
                //member - private field
                private string memberName;
                private string jobTitle;
                private int salary;

                //member - public field
                public int age;

                //member - property - exposes jobTitle safely - properties start with a capital letter 
                public string JobTitle { 
                    get
                    {
                        return jobTitle;
                    } 
                    set 
                    { 
                        jobTitle = value;
                    } 
                }
                *//*//public - member method - called from other classes
                public void Introducing(bool isFriend)
                {
                    if (isFriend)
                    {
                        SharePrivateInfo();
                    }
                    else {
                        Console.WriteLine("Hi my Name is {0}, my JobTitle is {1}, and my age is {1}", memberName, jobTitle, age);
                    }
                }
                private void SharePrivateInfo()
                {
                    Console.WriteLine("My salary is {0}", salary);
                }
                //constructor member
                public Practice()
                {
                    age = 30;
                    memberName = "licy";
                    salary = 600000;
                    jobTitle = "Developer";
                    Console.WriteLine("Object created");
                }
                //member - finalizer - destructor
                ~Practice() //whee=n ever the object runs out of
                {

                }*/

    }
}
