using System;
using System.Collections.Generic;
namespace FirstProject.obj
{
    public class vowel
    {
        static void Main3(string[] args)
        {
            System.Console.WriteLine("Enter the string");
            var sentence = System.Console.ReadLine();
            var updatedSentence = vowelRemover(sentence);
            System.Console.WriteLine(updatedSentence);
        }


        static string vowelRemover(string str)
        {
            var sentSplit = str.ToCharArray();
            var vowelString = new List<char>()
                { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string updatedSentence = "";
            for (var i = 0; i < sentSplit.Length; i++)
            {
                if (vowelString.Contains(sentSplit[i]))
                {
                    continue;
                }
                else
                {
                    updatedSentence += sentSplit[i];
                }
            }
            return updatedSentence;
        }
    }
}
