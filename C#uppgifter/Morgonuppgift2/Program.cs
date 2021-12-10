using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stigande = {4,3,5,2,-2,6};
            double[] svararr = {};
            
            
            Console.WriteLine("Unsorted:");
            foreach (int i in stigande) {
            Console.Write(i + " ");
            }
            
            Console.WriteLine("\n sorted:");
            Array.Sort(stigande);
            for(int i=0; i<stigande.Length; i++) {
            Console.Write(stigande[i] + " ");}

            Console.WriteLine("\n power of 2");
            foreach(int item in stigande){
                double svar = Math.Pow(item, 2);
                Console.WriteLine(svar);
                
            
            
                
            }
        } 

        
        
            
    }



    
            
    
}
