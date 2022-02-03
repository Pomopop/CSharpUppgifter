using System;
using System.Collections.Generic;

namespace morgonuppgift6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {-8, -2, 1,5, 4, 3, -3, -4 };
            var target = 0;

            var result = SumOfThrees(numbers, target);

            // Print
            foreach(var arr in result) {
                foreach(var val in arr) {
                    Console.Write(val+ " ");
                }
                Console.WriteLine();
            }
        }

        static List<int[]> SumOfThrees(int[] arr, int target) {
            List<int[]> result = new List<int[]>();

            Array.Sort(arr);

            for(int i =  0; i < arr.Length; i++) {
                int leftPointer = i + 1;
                int rightPointer = arr.Length - 1;

                while(leftPointer < rightPointer) {

                    int CurrentSum = arr[i] + arr[leftPointer] + arr[rightPointer];

                    if(CurrentSum == target) {
                        result.Add(new int[] {arr[i], arr[leftPointer], arr[rightPointer]});

                        leftPointer++;
                        rightPointer--;
                    }

                    if (CurrentSum > target) {
                        rightPointer--;
                    }

                    if (CurrentSum < target) {
                        leftPointer++;
                    }
                }
            }

            return result;

        }
    }
}



    

