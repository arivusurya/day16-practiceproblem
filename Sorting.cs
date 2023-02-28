public class InsertionSort{

    public void sort(int[] arr){
    int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }

        foreach (int i in arr){
            Console.WriteLine(i);
        }
    }

}


      


    

