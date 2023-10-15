using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Th6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1
                //Print on the screen in a column of numbers from 1 to n
                //(to solve the problem use the operators of cycles: for, while, do...while).

                /*Write("Enter n: ");                     //Ask user to enter n
                int n = Convert.ToInt32(ReadLine());

                int i = 1;                                 //Enter the counter

                WriteLine("\nYour numbers: \n");
                while (i <= n)                          //Use while
                {
                    WriteLine($"\t{i}");
                    i++;
                }

                do                          //Use do...while
                { 
                    WriteLine($"\t{i}");
                    i++;
                }
                while (i <= n);

                for (; i <= n; i++)            //Use for
                {
                    WriteLine($"\t{i}");
                }*/


                //Task 2
                //Print even two-digit numbers and count their quantity.

                /*int count = 0;              //Enter the counter

                WriteLine("All even two-digit numbers:\n");      //Print on the screen all even t-d numbers
                for(int i = 10; i <= 99; i++)                  //Use for
                {
                    if (i % 2 == 0)                         //Find the even t-d numbers
                    {
                        Write($"{i};\t");
                        count++;                            //Count their quantity
                    }
                }
                WriteLine($"\n\nQuantity of even two-digit numbers: {count}"); */     //Print on the screen quantity of even t-d numbers


                //Task 3
                //Make a table of values of the function y = 2х^2+4x-5 on the interval [-5; 5]
                //with step h = 0.2 (to complete the task use the operators of cycles: for, while, do...while).

                /*double x = -5;
                WriteLine("At y = 2 * х^2 + 4 * x - 5 we get: \n");

                WriteLine("\tx:\ty:\n");
                for (; x <= 5; x+=0.2)             //Use for
                {
                    WriteLine($"\t{x:f2} \t{2 * Math.Pow(x, 2) + 4 * x - 5:f2}");       //Print the values on the screen
                }

                /*while (x <= 5)                      //Use while
                {
                    WriteLine($"\t{x:f2} \t{2 * Math.Pow(x, 2) + 4 * x - 5:f2}");
                    x += 0.2;
                }

                do                      //Use do...while
                {
                    WriteLine($"\t{x:f2} \t{2 * Math.Pow(x, 2) + 4 * x - 5:f2}");
                    x += 0.2;
                }
                while (x <= 5);*/


                //Task 4
                //Find the sum of numbers divisible by 5 between 0 and 1000.

                /*int count = 0;      //Enter the counter

                WriteLine("All numbers divisible by 5:\n");     
                for (int i = 0; i <= 1000; i++)             //Use for
                {
                    if (i % 5 == 0)         //Find numbers divisible by 5 and print them on the screen
                    {
                        Write($"{i};\t");
                        count += i;         //Count their quantity
                    }

                }
                WriteLine($"\n\nThe sum of numbers divisible by 5: {count}");*/     //Enter their quantity


                //Task 5
                //Find the quantity of digits of a given number.

                /*Write("Enter a number: ");          //Ask user to enter a number
                int n = Convert.ToInt32(ReadLine());
                int count = 0;      //Enter counter

                while (n != 0)              //Use while
                {
                    n /= 10;            //Divide the number by 10 until it is smaller than or equal to zero
                    count++;            //Count the quantity of digits
                }
                Console.WriteLine($"\nThe quantity of digits: {count}");*/        //Print on the screen the quantity
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
