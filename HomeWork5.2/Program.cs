using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._2
{
    internal class Program
    { 
        static string Woods(string text)
        {
            string[] words = text.Split(new char[] {' ',',','.','!','?'},StringSplitOptions.RemoveEmptyEntries);
            int index = 0, minWords = words[0].Length;
            int index2 = 0, maxWords = words[0].Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length<minWords)
                {
                    minWords = words[i].Length;
                    index = i;
                }
                else if (words[i].Length>maxWords)
                {
                    maxWords = words[i].Length;
                    index2 = i;
                    
                }
            }
      
            return ($"Саммое мальнькое значение {words[index]}\nСамое большое значение {words[index2]}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            Console.WriteLine(Woods(text));
            Console.ReadKey();

        }
    }
}
