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
        //leetcoed : 380 Insert Delete GetRandom - use of list, dictionary, Random
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
                    dict[val] = list.Count; //if inserting 20 k0v20 20 = 0 k-0v-20, 10 = 1 k-1 v-10
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

        public static int FindMaxElementInArray(int[] arr)
        {
            if(arr.Length == 0) return int.MaxValue;
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        //Remove duplicated from Sorted Array
        public static int RemoveDuplicatesInArray(int[] arr)
        {
            HashSet<int> newArr = new HashSet<int>();
            //Hashset's nature is to only contains/store unique value
            int index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (!newArr.Contains(arr[i]))
                {
                    newArr.Add(arr[i]);
                    arr[index++] = arr[i]; //here index is acts like from 1 cause we are having length
                    //change values of index in array - can do index++ and arr[index] = arr[i]
                }
            }
            return index;
        }

        //move all zeros to end of Array - Not Best approach - O(n) Time and O(n) space for new array temp
        public static void moveZerosToEnd(int[] arr)
        {
            int arrLength = arr.Length;
            int[] tempArray = new int[arrLength]; 
            //creating new int array to store non zero values at first and zeros at last
            int tempIndex = 0; //track temp indexes
            for(int i = 0; i < arrLength; i++)
            {
                if( arr[i] != 0)
                {
                    tempArray[tempIndex++] = arr[i]; //1st stores non zero values
                }
            }
            while(tempIndex < arrLength)
            {
                tempArray[tempIndex++] = 0; //fill remaining temp indexes with zero
            }
            for(int i = 0; i < arrLength; i++)
            {
                arr[i] = tempArray[i]; //now copy sorted temp data to given array
            }
        }

        //move all zeros to end of Array - Best approach - O(n) Time and O(1) space
        public static void moveZerosToEndOfArray(int[] arr)
        {
            int arrLength = arr.Length;
            //int[] tempArray = new int[arrLength];
            //creating new int array to store non zero values at first and zeros at last
            int count = 0; //track temp indexes
            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i]; //1st stores non zero values
                }
            }
            while (count < arrLength)
            {
                arr[count++] = 0; //fill remaining temp indexes with zero
            }
            /*for (int i = 0; i < arrLength; i++)
            {
                arr[i] = tempArray[i]; //now copy sorted temp data to given array
            }*/
        }

        //find missing number from  1 to N and 0 to N - O(n) Time and Space Complexity
        public static int FindMissingNumber(int[] arr)
        {
            int n = arr.Length + 1; //missing is 1 so, increase index by only 1
            int[] hash = new int[n+1]; // create new array to store 
            for(int i = 0; i < n-1; i++)
            {
                hash[arr[i]]++; //add all array values
            }
            for(int i = 0; i <= n; i++)
            {
                if (hash[i] == 0)
                {
                    return i; //returns 0
                }
            }
            return -1; //returns missing value
        }

        //find missing number from 1 to N using LINQ - O(n) Time and O(1) Space Complexity
        public static int FindMissingNumberUsingLinq(int[] arr) 
        {
            int n = arr.Length+1;
            int sum = arr.Sum();
            int expSum = n * (n+1)/2;
            return expSum - sum; //LINQ works from 1 to N but not zero 0
        }
        //Reverse of string and check for pallindrome - reverse of string can be done 2 types
        //by using char[] array and
        //by using string of for loop and assign from last character to 1st in new string by using builtin function of ToString() to each iteration of i
        public static string ReversePalindromeOrNot(string name) {
            //Method 1 : reverse with string only - O(1) Time and O(n) space
            /*string reverse = "";
            for (int i = name.Length - 1; i >= 0; i--) {
                reverse += name[i].ToString();
            }
            return reverse;*/

            //Method 2: reverse the array: convert string to array and reverse it and give rversed string 
            char[] nameArray = name.ToCharArray();
            string revArray = string.Empty;
            for (int i = nameArray.Length - 1; i >= 0; i--)
            {
                revArray += nameArray[i]; //characters can append(+) to string to make complete string
            }
            return revArray;
        }

        public static void CoutVowelsConsonents(string name)
        {
            if (name != null)
            {
                /*
                //This won't work X I tried we get all consonents but vowels are 0 everytime 
                //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                string vowels = "aeiou";
                int countVowels = 0;
                int countConsonents = 0;
                name.ToLower();
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == vowels[i]) { countVowels++; }
                    else { countConsonents++; }
                    
                }*/

                //This will work because of hashset
                int countVowels = 0; int countConsonents = 0;
                HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
                name.ToLower();
                for (int i = 0; i < name.Length; i++)
                {
                    if (vowels.Contains(name[i])) { countVowels++; }
                    else { countConsonents++; }
                }
                Console.WriteLine("Vowel Count of name {0} is: {1}", name, countVowels);
                Console.WriteLine("Consonents Count of name {0} is: {1}", name, countConsonents);

            }
        }

        //Find the 1st non-repeating character O(n^2) Time and O(1) space
        public static char NonRepetingCharacter(string name) {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach(char c in name)
            {
                if (charCount.ContainsKey(c)) { charCount[c]++; }
                else { charCount[c] = 1; }
            }
            foreach(char c in name)
            {
                if (charCount[c] == 1) { return c; }
            }
            return '_';
        }
        //Frequency of each element in an array
        public static void FrequencyOfEachElement(int[] nums) //for chars char[] chars
        {
            var freqCount = new Dictionary<int, int>(); //can have chars also <char, int>
            foreach (var item in nums)
            {
                if (freqCount.ContainsKey(item)) { freqCount[item]++; }
                else { freqCount[item] = 1; }
            }
            foreach(var item in freqCount)
            {
                Console.WriteLine("Element : Frequency");
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
        //Anagrams check - O(n) - Time O(1) - Space Complexity
        public static bool AnagramString(string s1, string s2)
        {
            if (s1.Length != s2.Length) { return false; }
            Dictionary<char, int> countMap = new Dictionary<char, int>();
            foreach (char c in s1) // Count frequency of each character in s1
            {
                if (countMap.ContainsKey(c)) { countMap[c]++; }
                else
                {
                    countMap[c] = 1;
                }
            } 
            foreach (char c in s2) // Subtract frequency based on characters in s2
            {
                if (!countMap.ContainsKey(c)) { return false; }
                countMap[c]--;  // If count goes below zero, it's not an anagram
                if (countMap[c] < 0) { return false; }
            }
            return true;
        }

        //Find a Pair With a Given Sum - prefer 2 pointer approach, requirement is array should be sorted - O(n) Time,O(1) space 
        public static bool TargetSumofArrayPair(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right) { 
                int sum = arr[left] + arr[right];
                if(sum == target) 
                {
                    Console.WriteLine("The pair of sum is: " + arr[left]+" and " + arr[right]);
                    return true;
                }
                else if (sum > target)
                    right--;
                else
                    left++;
            }
            Console.WriteLine("Pair of sum not found.");
            return false;
        }
        //Binary Search in searching and sorting technique - prerequisit: Array must be sorted by ascending or descending
        //Split array into 2 by using mid, search for given element in array
        public static int BinarySearch(int[] num, int target)
        {
            int low = 0;
            int high = num.Length - 1;
            while (low <= high) {
                int mid = low + (high - low) / 2;
                if(num[mid] == target)
                    return mid;
                else if(num[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
        public static void ReverseFromIndex(int[] arr, int m){
            int start = m;
            int end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start]; arr[start] = arr[end]; arr[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine("The Array is: ");
            foreach (int n in arr) {
                Console.WriteLine(n+" ");
            }
        }

        //Reverse a Linked List
        public class Node
        {
            public int val;
            public Node next;
            public Node(int val)
            {
                this.val = val;
                this.next = null;
                Console.WriteLine(val+" ");
            }
        }
            public static Node reverse_List(Node head)
            {
                if (head == null || head.next == null) //edge case : empty list or only 1 value node list
                {
                    return head;
                }
                Node prev = null;
                Node current = head;
                while (current != null)
                {
                    Node next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                return prev;
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
