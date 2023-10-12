using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Console.Write("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                while(n != 0)
                {
                    n /= 10;
                    count++;
                }
                Console.WriteLine(count);*/

                //Т7.1
                //Задание 1
                //Соответствие номера из таблицы Unicode символу.

                /*for(int i = 0; i <= 256; i++)
                 {
                     Console.WriteLine($"Код {i} cooтветствует символу {(char)i}") ;

                 }*/
                //Task 2
                /*Console.Write("Введите символ: ");
                char cr = char.Parse(Console.ReadLine());
                Console.WriteLine($"Сивол имеет код: {(int)cr}");*/

                //Task 3
                //Дан символ. Вывести символ, который в кодовой таблице ASCII следует за этим символом

                /*Console.Write("Введите символ: ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine($"Сивол имеет код: {(char)(int)(ch+1)}");*/

                //Task 4
                //Дан символ. Вывести два символа, стоящие перед ним в кодовой таблице ASCII

                /*Console.Write("Введите символ: ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine($"Сивол имеет код: {(char)(int)(ch - 1)}; {(char)(int)(ch - 2)}");*/
                //Task 5
                //Дан символ. Вывести два символа, первый из которых предшествует введенному символу в кодовой таблице, а второй – следует после него

                /*Console.Write("Введите символ: ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine($"Сивол имеет код: {(char)(int)(ch - 1)}; {(char)(int)(ch + 1)}");*/

                //Task 6
                //Дано название футбольного клуба. Напечатать его на экране «столбиком»

                /*Console.WriteLine("Введите название клуба: ");
                string ch = Console.ReadLine();
                char[] chars = ch.ToCharArray();
                foreach(char cr in chars)
                {
                    Console.WriteLine($"{cr}");
                }*/

                //Task 7
                //Составить программу, которая печатает заданное слово, начиная с последней буквы
                /*Console.WriteLine("Ввеедите слово: ");
                string word= Console.ReadLine();
                char[] chars = word.ToCharArray();
                for(int a= word.Length-1; a>=0; a--)
                {
                    Console.WriteLine($"{chars[a]}");
                }*/

                //Task 8
                //Преобразовать символы в строке из строчных в прописные и обратно
                /*Console.WriteLine("Ввеедите слово: ");
                string word = Console.ReadLine();
                Console.WriteLine($"{word.ToUpper()}  {word.ToLower()}");*/






            }
            catch
            {

            }
            Console.ReadKey();
        }
    }
}
