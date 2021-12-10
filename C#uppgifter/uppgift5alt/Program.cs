using System;

namespace morgonuppgift1_5_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queue = {6,1,2, 2,3};
            var results = MinWaitTime(queue);
            Console.WriteLine(results);
        }

        static int MinWaitTime(int[] queue) {
            Array.Sort(queue);

            int currValue = 0;
            int returnValue = 0;
            for (int i = 0; i < queue.Length -1; i++) {
                // Tar en siffra på position i och lägger på den på currValue
                currValue += queue[i];
                // i=0 => 1 currValue = 1
                // i=1 => 2 currValue = 3
                // i=2 => 2 currValue = 5
                // i=3 => 3 curr = 8
                // i=4 => 6 curr = 14
                // Adderar currValue på returnValue
                returnValue += currValue;
            }

            return returnValue;

        }
    }
}