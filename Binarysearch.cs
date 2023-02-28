public class BinarySearch{


    public void Search(String[] list, string element){
   
        int  left = 0;
        int right = list.Length-1;
        int Mid = left + right /2;
        Array.Sort(list);
        foreach(string item in list){
            Console.WriteLine(item);
        }

        while(left<=right){
            int compare = String.Compare(element,list[Mid]);

            if(compare == 0){
                Console.WriteLine("Element {0} found in {1}",element,Mid);
                return;
            }
            if(compare<0){
                right = Mid-1;
                Mid = left + right /2 -1;
            }
            if(compare > 0){    
               left = Mid + 1;
               Mid = left + right /2 -1;
            }
        }
        Console.WriteLine("Element not found in the Array");

       
       
    }
}