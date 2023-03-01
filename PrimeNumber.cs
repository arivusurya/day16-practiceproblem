public class PrimeNumber{

    public void PrintPrime(int start, int end){
      

        for (int i=2;i<=end;i++){
             int flag =  0;
             for(int j=2;j<i;j++){
                if(i%j ==0){
                    flag = 1;
                }
             } 
             if(flag == 0){
                Console.WriteLine(i);
             }
        }   

    }

}