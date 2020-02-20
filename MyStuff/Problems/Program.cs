using System;

namespace Problems
{
    public class Program
    {
        static string Prefix(string input)
        {
            int numChar = input.Length;
            string num = numChar.ToString();
            
            int numWords = input.Split().Length;
            string numW = numWords.ToString();
            string value = num + "," + numW + ":" + input ;
            Console.WriteLine(num + "," + numW + ":" + input);
            return value;
        }

        static void Main(string[] args)
        {
            string word = "Hello World!";
            string sentence = Prefix(word);
            Console.WriteLine(sentence);
        }
    }
}
