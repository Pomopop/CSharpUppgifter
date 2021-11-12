using System;

namespace ObjOrienterat
{
    class Program
    {
        static void Main(string[] args)
        {




            int[] arr = {1,2,3,4,5};
            int Måltal = 9;


            arrayLoop()
        }


        static int[] arrayLoop(int[] arr, int Måltal)
        {
            

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(i + j == Måltal)
                    {
                        return new int[] {i,j};

                    }
                }
            }
            return arr;
         }


    }


    
}
