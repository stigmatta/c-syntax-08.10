using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
                /*Задание 1
                Выведите на экран цитату Бьярна Страуструпа: It's easy
                to win forgiveness for being wrong; being right is what gets you
                into real trouble.*/
                Console.WriteLine("It's easy to win forgiveness for being wrong;");
                Console.WriteLine("being right is what gets you into real trouble.");
                Console.WriteLine("Bjarne Stroustrup");
            #endregion

            #region

            /*Задание 2
            Пользователь вводит с клавиатуры пять чисел. Не-
            обходимо найти сумму чисел, максимум и минимум из
            пяти чисел, произведение чисел. Результат вычислений
            вывести на экран.*/
            int min = int.MaxValue; 
            int max = int.MinValue; 
            int sum = 0;
            int multiply = 1;

            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                multiply *= num;
                if (num < min) min = num; 
                if (num > max) max = num; 
            }

            Console.WriteLine("Sum: " + sum); 
            Console.WriteLine("Multiply: " + multiply); 
            Console.WriteLine("Min: " + min); 
            Console.WriteLine("Max: " + max);
            #endregion


            #region
            /*Задание 3
            Пользователь с клавиатуры вводит шестизначное число.
            Необходимо перевернуть число и отобразить результат.
            Например, если введено 341256, результат 652143.*/

            string digit;

            while (true)
            {
                Console.Write("Введите 6-значное число: ");
                digit = Console.ReadLine();

                if (digit.Length == 6)
                    break; 
                else
                    Console.WriteLine("Ошибка: Пожалуйста, введите 6-значное число.");
            }
            string reversedString = new string(digit.Reverse().ToArray());
            Console.WriteLine($"Вы ввели 6-значное число: {reversedString}");

            #endregion

            #region
            /* Задание 4
            Пользователь вводит с клавиатуры границы числового
            диапазона.Требуется показать все числа Фибоначчи из
            этого диапазона. Числа Фибоначчи — элементы числовой
            последовательности, в которой первые два числа равны 0
            и 1, а каждое последующее число равно сумме двух пре-
            дыдущих чисел.Например, если указан диапазон 0–20,
            результат будет: 0, 1, 1, 2, 3, 5, 8, 13.*/

            Console.WriteLine("Введите границу числового диапазона: ");
            int a = int.Parse(Console.ReadLine());


            int tempX = 0;
            int tempY = 1;

            Console.Write(tempX + "," + tempY);
            int current = tempX+tempY;

            while (current <= a)
            {
                Console.Write("," + current );
                tempX = tempY;
                tempY = current;
                current = tempY + tempX;
            }

            Console.WriteLine();
            #endregion

            #region
            /* Задание 5
            Даны целые положительные числа A и B (A < B). Выведите все целые числа от A до B включительно; каждое
            число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз,
            равное его значению. Например: если A = 3, а B = 7, то программа должна сформировать в консоли следующий вывод:
            3 3 3
            4 4 4 4
            5 5 5 5 5
            6 6 6 6 6 6
            7 7 7 7 7 7 7. */

            int A;
            int B;

            while (true)
            {
                Console.Write("Введите A: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Введите B: ");
                B = int.Parse(Console.ReadLine());

                if (A < B)
                    break;
                else
                    Console.WriteLine("A должно быть строго меньше B. Попробуйте снова.");
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " "); 
                }
                Console.WriteLine();
            }
            #endregion

            #region
            /*Задание 6
            Пользователь с клавиатуры вводит длину линии, сим-
            вол заполнитель, направление линии(горизонтальная,
            вертикальная). Программа отображает линию по заданным
            параметрам.Например: +++++.
            Параметры линии: горизонтальная линия, длина равна
            пяти, символ заполнитель +.*/

            Console.WriteLine("Впишите длину линии:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Впишите символ-заполнитель:");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Выберите направление линии(1-горизонтальная,2-вертикальная):");
            int direction = int.Parse(Console.ReadLine());

            for(int i = 0;i < length; i++)
            {
                if(direction == 1)
                    Console.Write(symbol);
                else if(direction == 2)
                    Console.WriteLine(symbol);
            }

            #endregion

        }
    }
}
