using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment001
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1.CheckPerfectNumber();


            //2. MinimumGap();


            //3. FindPairs();



            /* question 4:
             * 
             * Console.WriteLine("Enter the string number : ");
             var str=Console.ReadLine();

             MagicalNumber(str);*/





            /*  question 5:
             string s;
            Console.Write("Enter a string : ");
            s = Console.ReadLine();

            s = s.Trim();
            SpaceRemove(s);
            */


            //question 6:

            /*  Console.WriteLine("enter the  size of the array");
              int  k= int.Parse(Console.ReadLine());
              int[] arr1 = new int[k];
              Console.WriteLine("Enter the elements in array ");
              for (int i = 0; i < k; i++)
              {

                  arr1[i] = int.Parse(Console.ReadLine());
              }

              Console.WriteLine("Third largest element in array is : " + FindThirdLargest(arr1));*/


            /* 7..
            Console.WriteLine("Enter the size of an array : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];

            Console.WriteLine("Enter the elements in array ");
            for (int i = 0; i < n; i++)
            {

                arr1[i] = int.Parse(Console.ReadLine());
            }

            ProductOfArray(arr1);

            */
        }


        //Question 1:


        /*public static void CheckPerfectNumber()
         {
             Console.Write("Please enter a number: ");
             int number = int.Parse(Console.ReadLine());

             if (number == 0)
             {
                 Console.WriteLine($"No, {number} Not perfect number.");
                 return;
             }

             int sumOfDivisors = 0;
             for (int i = 1; i <= number / 2; i++)
             {
                 if (number % i == 0)
                 {
                     sumOfDivisors += i;
                 }
             }

             if (sumOfDivisors == number)
             {
                 Console.WriteLine($"Yes, {number} perfect number.");
             }
             else
             {
                 Console.WriteLine($"No, {number}Not perfect number.");
             }
         }*/


        // Queestion 2:
        /* private static int UtilMinimumGap(int input)
         {
             int SqrtCeilOfDigit = (int)Math.Ceiling(Math.Sqrt(input));
             int SqrtFloorOfDigit = (int)Math.Floor(Math.Sqrt(input));

             int ceilPerfect = SqrtCeilOfDigit * SqrtCeilOfDigit;
             int floorPerfect = SqrtFloorOfDigit * SqrtFloorOfDigit;

             int minimumGapRequired = Math.Min(ceilPerfect - input, input - floorPerfect);

             return minimumGapRequired;
          }
     public static void MinimumGap()
     {
         int input;
         Console.Write("Enter a Number : ");
         input = Convert.ToInt32(Console.ReadLine());

         int result = UtilMinimumGap(input);

         Console.WriteLine("The minimum gap to make {0} a perfect square is {1}", input, result);
     }*/

        //Question 3:

        /*  public static void PairSum(int[] array, int size, int targetSum)
          {
            Console.WriteLine("Pairs with sum less than " + targetSum + ":");

                  for (int i = 0; i<size - 1; i++)
                  {
                      for (int j = i + 1; j<size; j++)
                      {
                          if (array[i] + array[j] < targetSum)
                          {
                            Console.WriteLine("[{0},{1}] with indices ({2},{3})",array[i] , array[j] , i , j);

                      }
                  }
      }
  }
                  public static void FindPairs()
              {
                  int size;
                  Console.Write("Enter the size of array : ");
                  size = Convert.ToInt32(Console.ReadLine());

                  int[] array = new int[size];
                  for (int i = 0; i < size; i++)
              {
                  Console.Write(String.Format("Enter element at index {0} : ", i));
                              array[i] = Convert.ToInt32(Console.ReadLine());
                          }

                       Console.WriteLine("\nArray is : ");
                          for (int i = 0; i<size; i++)
                          {
                              Console.Write("{0} ", array[i]);
                          }

                   int target;
                   Console.Write("\n\nEnter your target value : ");
                   target = Convert.ToInt32(Console.ReadLine());

                   PairSum(array, size, target);
                      }
        */
        // question 4:
        /* static void MagicalNumber(string str)
         {
             int num = int.Parse(str);
             int sum = 0;
             while (num != 0)
             {
                 int lastdigit = num % 10;
                 sum += lastdigit;
                 num = num / 10;
                 if (num == 0 && sum > 9)
                 {
                     num = sum;
                     sum = 0;
                 }
             }
             Console.WriteLine("Sum : " + sum);
             if (sum == 1)
                 Console.WriteLine("Magical Number");
             else Console.WriteLine("It is not a magical number ");

         }
         */
        //UPDATED MAGICAL STRING USING STRING BUILDER AND STRING OPERATIONS .
        /*
        private static bool IsMagical(string str)
        { 
            StringBuilder sb = new StringBuilder(str);
            int sum = 0;
            bool endProcess = false;
            while (!endProcess)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    int n = sb[i] - '0';
                    sum += n;
                }
                if (sum >= 10)
                {
                    sb.Clear();
                    sb.Append(sum.ToString());
                    sum = 0;
                }
                else
                {
                    endProcess = true;
                }
            }
            return sum == 1;
        }
*/

        
        //question 5:
        /* static void SpaceRemove(string s)
         {
             string result = "";
             for (int i = 0; i < s.Length; i++)
             {
                 if (s[i] == ' ' && (i + 1 < s.Length && s[i + 1] == ' '))
                 {
                     continue;
                 }
                 else
                 {
                     result += s[i];
                 }
             }
             Console.WriteLine(result);
         }*/




        //question 6:
        /* static int FindThirdLargest(int[] arr)
         {
             if (arr.Length < 3)
             {
                 Console.WriteLine("enter more than 2 numbers");
             }

             int first = int.MinValue;
             int second = int.MinValue;
             int third = int.MinValue;

             foreach (int num in arr)
             {
                 if (num > first)
                 {
                     third = second;
                     second = first;
                     first = num;
                 }
                 else if (num > second && num < first)
                 {
                     third = second;
                     second = num;
                 }
                 else if (num > third && num < second)
                 {
                     third = num;
                 }
             }

             return third;
         }
        */

        // 7.
        /*static void ProductOfArray(int[] arr)
        {
            int[] ans = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                var product = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                        product = product * arr[j];

                }
                ans[i] = product;
            }
            Console.WriteLine("Final Array : ");
            for (int k = 0; k < ans.Length; k++)
            {
                Console.WriteLine(ans[k]);
            }
        }

        */

    }
}
