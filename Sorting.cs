public class BubbleSort{

    public void sort(int[] list){

        
      
        for(int i=0;i<list.Length-1;i++){
            for(int j =0;j<list.Length-1;j++){
                if(list[j]>list[j+1]){
                   int temp = list[j];
                   list[j] = list[j+1];
                   list[j+1] = temp;
                }
            }
        }
        foreach(int item in list){
            Console.WriteLine("{0} ",item);
        }
    }
}

      


    

