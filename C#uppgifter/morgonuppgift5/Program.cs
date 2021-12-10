using System;

namespace morgonuppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = {6,1,2,2,3};
            var result = calc(heltal);
            Console.WriteLine(result);
        }
      
        public static int calc(int[] heltal)
        {
            Array.Sort(heltal);
            var total = 0;

            for(int i = 0; i < heltal.Length; i++){
                var segment = new ArraySegment<int>(heltal,0,i);
                var seg_sum = 0;
                
                
                foreach(var number in segment){
                seg_sum = seg_sum + number;
                }

            

            total += seg_sum;

            }
        return total;
        }
    }
}
    

