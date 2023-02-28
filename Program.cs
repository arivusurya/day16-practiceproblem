using System;

namespace Algoriths{
    public class Program{
        public static void Main(string[] args)
        {
            string[] words = {"hello","world","mycomputer","notworking","notthis"};
            BinarySearch bs = new BinarySearch();
            bs.Search(words,"notworking");

        }
    }

}