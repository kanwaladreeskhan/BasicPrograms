using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program 1
            Console.WriteLine("Program 1\nSum of Elements of an array:");
            int[] array = new int[6];
            int sum = 0;
            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element {0}:", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Sum of elements in given array = {0}:", sum);


            //Program 2
            Console.WriteLine("Program 2\nCount Even & Odd Numbers:");
            Console.WriteLine("Enter the total numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] count = new int[n]; int even = 0, odd = 0;
            Console.WriteLine("Enter numbers:"); for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Number {0}:", i + 1);
                count[i] = Convert.ToInt32(Console.ReadLine());
                if (count[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Total Numbers = {0}\nTotal Even numbers ={1}\nTotal Odd numbers = {2}", n, even, odd);


            //Program 3
            Console.WriteLine("Program 3\nReverse Array Output:");
            int[] arr = new int[7]; Console.WriteLine("Enter Elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            { Console.Write("{0}   ", arr[i]); }
            Console.ReadLine();


            //Program 4
            Console.WriteLine("Program 4\nSearch a Number:");
            int[] list = new int[7]; int index = 0;
            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Element {0}:", i + 1);
                list[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number to search from the given array:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == num)
                {
                    index = i;
                }
            }
            if (index != 0)
            {
                Console.WriteLine("The number exists at index {0}", index);
            }
            else
            {
                Console.WriteLine("The number does not exist in given array!");
            }


            //Program 5
            Console.WriteLine("Program 5\nCheck for Palindrome Numbers in Array:");
            int[] palindrome = new int[5];

            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < palindrome.Length; i++)
            {
                Console.WriteLine("Element {0}:", i + 1);
                palindrome[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < palindrome.Length; i++)
            {
                if (IsPalindrome(palindrome[i]))
                {
                    Console.WriteLine(palindrome[i] + " is a Palindrome number.");
                }
                else
                {
                    Console.WriteLine(palindrome[i] + " is not a palindrome number.");  
                }
            }
        }
        static bool IsPalindrome(int m)
        {
            string inp = m.ToString();
            string reverse = "";
            for (int i = inp.Length - 1; i > -1; i--)
            {
                reverse += inp[i];
            }
            if (reverse == inp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
