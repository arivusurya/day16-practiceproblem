using System;

namespace Algoriths{
    public class Program{
        public static void Main(string[] args)
        {
         int[] arr = {1,3,4,2,9,7};
         InsertionSort Is = new InsertionSort();
         Console.WriteLine("Before Sorting");
         foreach(int i in arr){
            Console.WriteLine(i);
         }

         Console.WriteLine("After sorting");
         Is.sort(arr);
        }
    }

}