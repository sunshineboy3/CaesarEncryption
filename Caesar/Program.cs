using System;
using System.Collections.Generic;
using System.Linq;

namespace Caesar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово, которое нужно зашифровать:");
            var s = Console.ReadLine();
            const string alfphabet = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЬЪЭЮЯ ";
            Console.WriteLine();
            for (var i = 0; i < alfphabet.Length; i++)
            {
            	Console.Write("{0,3}", alfphabet[i]);
            }
            Console.WriteLine();
            for (var i = 0; i < alfphabet.Length; i++)
            {
            	Console.Write("{0,3}", i);
            }
            Console.WriteLine();            	
            var m = alfphabet.Length;
            var result = new List<string>();
            for (var y = 1; y < m; y++)
            {
                result.Add(Shift(s, alfphabet, y));
            }
            Console.WriteLine();
            var k = 1;
            foreach (var word in result)
            {
                Console.WriteLine("Зашифрованное слово (сдвиг на {0}): {1}", k, word);
                k += 1;
            }

            Console.ReadKey(true);
        }

        static string Shift(string targetWord, string alfphabet, int key)
        {
            var result = string.Empty;
            for (var i = 0; i < targetWord.Length; i++)
            {
                for (var j = 0; j < alfphabet.Length; j++)
                {
                    if (targetWord[i] == alfphabet[j])
                    {
                        var temp = j + key;
                        while (temp >= alfphabet.Length)
                        {
                            temp -= alfphabet.Length;
                        }
                        result += alfphabet[temp];
                    }
                }
            }
            return result;
        }
    }
}