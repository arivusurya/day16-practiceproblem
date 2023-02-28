using System;


public class Anagram{

    public void checkAnagran(string word1,string word2){
        if(word1.Length == word2.Length){
            char [] str1 = word1.ToLower().ToCharArray();
            char [] str2 = word2.ToLower().ToCharArray();

            Array.Sort(str1);
            Array.Sort(str2);

            word1 = new String(str1);
            word2 = new String(str2);

            if(word1 == word2){
                Console.WriteLine("Both are anagram");
            }else{
                Console.WriteLine("not an anagram");
           }
        }else{
            Console.WriteLine("Not an anagram");
        }

    }

}