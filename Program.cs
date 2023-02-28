using System;

namespace Algoriths{
    public class Program{
        public static void Main(string[] args)
        {
          int[] list = {5,1,2,4};
          BubbleSort bs =new BubbleSort();
          Console.WriteLine("Before Sorting");
          foreach(int i in list){
            Console.WriteLine("{0} ",i);
          }
          Console.WriteLine("After sortig");
          bs.sort(list);

        }
    }

}