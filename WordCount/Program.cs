using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = " a text, some text , just some text";

            IDictionary<string , int> myDictionatry = new Dictionary<string , int>();

            string[] words = text.Split(' ', ',', '.') ;

            foreach (string word in words)
            {
                int count = 1;
                if (myDictionatry.ContainsKey(word))
                {
                    count = myDictionatry[word] +1;
                    
                } else
                {
                   myDictionatry[word] =1;

                }

            }

            foreach(var pair in myDictionatry)
            {
                Console.WriteLine($"{pair.Key} ==> {pair.Value}");
            }

            Console.ReadLine();
        }
    }
}
