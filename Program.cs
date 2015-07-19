using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string S = Console.ReadLine();
            
            S = S.ToLower();

            char[] F = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm'};
            int k = 0;
            foreach (char d in S)
            {
                if (F.Contains(d))
                    k++;
            }
            if (k > 0)
                Console.WriteLine("Ошибка! Строка содержит символы латиницы");
            else
            {
                char[] C = { 'а', 'о', 'у', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е' };
                int i = 0;
                foreach (char d in S)
                {
                    if (C.Contains(d))
                        i++;
                }
                char[] G = { 'й', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', 'ф', 'в', 'п', 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'ь', 'б' };
                int j = 0;
                foreach (char d in S)
                {
                    if (G.Contains(d))
                        j++;
                }
                char[] Z = { '.', ',', ';', ':', '!', '?', '"', '-', '(', ')' };
                int x = 0;
                foreach (char d in S)
                {
                    if (Z.Contains(d))
                        x++;
                }
                char[] T = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int n = 0;
                foreach (char d in S)
                {
                    if (T.Contains(d))
                        n++;
                }
                Console.WriteLine("Гласных букв в строке: {0}", i);
                Console.WriteLine("Согласных букв в строке: {0}", j);
                Console.WriteLine("Знаков препинания в строке: {0}", x);
                Console.WriteLine("Цифр в строке: {0}", n);
            }
            Console.ReadLine();

        }
    }
}
