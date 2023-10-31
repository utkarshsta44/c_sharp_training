using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //1.
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter element at index {0} : ", i));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(CountLeaders(array));
        }

        //Question 1:
        public static int BalancedIndex(int[] arr)
        {
            int totalSum = 0;
            int leftSum = 0;

            foreach (int num in arr)
            {
                totalSum += num;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                totalSum -= arr[i];

                if (leftSum == totalSum)
                {
                    return i;
                }

                leftSum += arr[i];
            }

            return -1;
        }

        //2.   
        public static int CountLeaders(int[] arr)
        {
            int maxRight = int.MinValue;
            int count = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > maxRight)
                {
                    count++;
                    maxRight = arr[i];
                }
            }

            return count;
        }



        //3.
        public static int switchcount(int[] arr)
        {
            int count = 0;
            foreach (var it in arr)
            {
                int currentstate = arr[it];
                if (count % 2 == 1)
                {
                    currentstate = arr[it] == 0 ? 1 : 0;
                }
                if (currentstate == 0)
                {
                    count++;
                }
            }
            return count;
        }


        public static int MinSwitchesToTurnOnAllBulbs(int[] bulbs)
        {
            int count = 0;

            for (int i = 0; i < bulbs.Length; i++)
            {
                if (bulbs[i] == 0)
                {
                    count++;
                    bulbs[i] = 1;

                    for (int j = i + 1; j < bulbs.Length; j++)
                    {
                        bulbs[j] = 1 - bulbs[j];
                    }
                }
            }

            return count;
        }






        //4.
        public static int MaxSubarraySum(int[] arr)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;

            foreach (int num in arr)
            {
                currentSum = Math.Max(num, currentSum + num);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}


