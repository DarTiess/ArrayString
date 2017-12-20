using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    class Program
    {
        static void Main(string[] args)
        {

            //4.Подсчитать количество слов во введенном предложении.

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введие  предложение ");
            Console.ForegroundColor = ConsoleColor.White;
            string stroka = Console.ReadLine();
            int count = 0;
            string[] strokaB = stroka.Split();
            foreach (var item in strokaB)
            {
                count++;
            }
            Console.WriteLine("Вы ввели " + count + " слов");
            Console.WriteLine();
        

            //8.Составить программу, которая подсчитывает, сколько содержится цифр в
            //строке длиной 20 символов.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите строку длиной 20 символов");
            Console.ForegroundColor = ConsoleColor.White;
            stroka = Console.ReadLine();
            char[] strokaC = stroka.ToCharArray();
            int quant = 0;
            while (stroka.Count()<20) {

                Console.WriteLine("Введите строку длиной 20 символов! Не меньше!");
                stroka = Console.ReadLine();
            }
            if (strokaC.Length >= 20)
            {
                for (int i = 0; i < 20; i++)
                {

                    if (Char.IsNumber(strokaC[i]))
                    {
                        quant++;
                    }

                }
            }
            Console.WriteLine("В первых 20 символах " + quant + " цифр(ы) \n");
            Console.WriteLine();
           

            //--------
            //Вывести элементы числового массива, которые больше, чем элементы, 
            //стоящие перед ними.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Вывести элементы числового массива, которые больше, чем элементы, стоящие перед ними");
            Console.ForegroundColor = ConsoleColor.White;
            int[] number = new int[10];
            var rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                number[i] = rnd.Next(9);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            for(int i = 0; i < 9; i++)
            {
                if (number[i + 1] > number[i])
                {
                    Console.Write(number[i+1] + " ");
                }
            }
            Console.WriteLine();

            //--
            //Все элементы массива поделить на значение наибольшего элемента этого
            //массива.
            //Решение
            //Задача состоит из двух подзадач:

            //Поиск максимума.
            //Деление на него элементов массива.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Все элементы массива поделить на значение наибольшего элемента этого массива");
            Console.ForegroundColor = ConsoleColor.White;
            int maximum = number.Max();
            Console.WriteLine(maximum + " - максимальное число массива");
            Console.WriteLine("Результат деления ");
            for(int i = 0; i < number.Length; i++)
            {
                number[i] /= maximum;
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            //--
            //Найти номер и значение первого положительного элемента массива.
            //Решение
            //Данная задача решается просто, если использовать оператор break. 
            //Массив перебирается в цикле. Каждый элемент проверяется на 
            //условие "больше нуля".Как только оно будет выполнено, элемент
            //следует вывести на экран, а цикл прервать.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Найти номер и значение первого положительного элемента массива");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(-9, 9);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Первый положительный элемент массива - ");
             foreach(var i in number)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                else continue;
            }
            Console.WriteLine();
            //--
            //Дан массив, содержащий положительные и отрицательные числа.
            //Заменить все элементы массива на противоположные по знаку.

            //Например, задан массив[1, -5, 0, 3, -4]. После преобразования 
            //должно получиться[-1, 5, 0, -3, 4].
            //Решение
            //Чтобы поменять элемент на противоположный, достаточно умножить его на - 1.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Заменить все элементы массива на противоположные по знаку");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(-9, 9);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            for(int i=0;i<number.Length;i++)
            {
                  number[i] *= (-1);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            //--
            //В массиве найти минимальный и максимальный элементы, поменять их местами.
            //Решение
            //При поиске минимального и максимального элемента следует запоминать их 
            //индексы, а не значения.Поиск выполняется в цикле for, в котором
            //с помощью условного оператора проверяется каждый элемент массива.
            //Если он больше(или меньше), чем элемент по индексу, который сохранен
            //в соответствующей переменной, то следует в эту переменную записать
            //индекс текущего элемента.

            //После цикла необходимо значение максимального элемента поставить в место 
            //массива, имеющее индекс минимального элемента.Чтобы не потерять при 
            //этом минимум, следует сохранить его в отдельной(буферной) переменной.
            //Это значение потом будет присвоено по индексу максимального элемента.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("В массиве найти минимальный и максимальный элементы, поменять их местами.");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(-9, 9);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            maximum = number.Max();
            int minimum = number.Min();
            Console.WriteLine("Максимальный элемент = "+ maximum+". Минимальный элементы = "+minimum);
            for (int i = 0; i < number.Length; i++)
            {
                int tempMin = 0;
                int tempMax = 0;
                if (number[i] == minimum)
                {
                    tempMin = i;
                }
                if (number[i] == maximum)
                {
                    tempMax = i;
                }

                number[tempMax] = minimum;
                number[tempMin] = maximum;
            }
            foreach(var i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //--
            //В одномерном массиве найти минимальный и максимальный элементы.
            //Вычислить их разность.

            //Например, дан массив[3, 5, 9, 4, 2, 6].Максимальным числом является 9, 
            //минимальным является 2.Разность составляет 9 - 2 = 7.
            //Решение
            //В данном случае минимум и максимум можно искать по индексу и по значению.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("В одномерном массиве найти минимальный и максимальный элементы. Вычислить их разность.");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <number.Length; i++)
            {
                number[i] = rnd.Next(1,9);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            maximum = number.Max();
           minimum = number.Min();
            Console.WriteLine("Максимальный элемент = "+maximum+". Минимальный элемент = "+minimum);
            Console.WriteLine("Разность = " + (maximum - minimum));
            Console.WriteLine();
            //--
            //Найти сумму тех элементов массива, которые одновременно имеют четные и 
            //отрицательные значения.

            //Например, в массиве[3, -5, -2, 4, -8, 0] отрицательными четными элементами 
            //являются числа - 2 и - 8.Их сумма равна - 10.
            //Решение
            //Для решения поставленной задачи надо проверить каждый элемент массива
            //на отрицательность и на четность.Сделать это можно в заголовке 
            //оператора ветвления, используя сложное логическое выражение с
            //оператором and.Если текущий элемент массива отрицателен(< 0) и
            //четный, то добавляем его значение к переменной, в которой
            //накапливается сумма.

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Найти сумму тех элементов массива, которые одновременно имеют четные и отрицательные значения.");
            Console.ForegroundColor = ConsoleColor.White;
            count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(-9, 9);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Отрицательными четными элементами являются числа ");
            for (int i = 0; i < number.Length; i++)
            {
                if ((number[i] < 0) && ((number[i] % 2) == 0))
                {
                    Console.Write(number[i] + " ");
                    count += number[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма = "+count);
            Console.WriteLine();
            //--
            //В массиве найти минимальное значение среди элементов с нечетными индексами.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("В массиве найти минимальное значение среди элементов с нечетными индексами.");
            Console.ForegroundColor = ConsoleColor.White;
            minimum = number.Max();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(-9, 9);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Элементы с нечетным индексом :");
            for(int i = 0; i < number.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(number[i] + " ");
                    if (minimum > number[i])
                    {
                        minimum = number[i];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Минимальный элементы = "+minimum);
            Console.WriteLine();
            //--
            //Дан одномерный массив.Найти среднее арифметическое его элементов.
            //Вывести на экран только те элементы массива, которые больше 
            //найденного среднего арифметического.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Вывести на экран только те элементы массива, которые больше среднего арифметического.");
            Console.ForegroundColor = ConsoleColor.White;
            count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1, 9);
                Console.Write(number[i] + " ");
                count += number[i];
            }
            Console.WriteLine();
            count = count / number.Count();
            Console.WriteLine("Среднее арифметическое = "+count);
            Console.WriteLine("Элементы больше среднего арифметического : ");
           foreach(var i in number)
            {
                if (i > count)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            //--
            //В одномерном массиве найти количество положительных элементов.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("В одномерном массиве найти количество положительных элементов.");
            Console.ForegroundColor = ConsoleColor.White;
             count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(-9, 9);
                Console.Write(number[i] + " ");
                if (number[i] > 0)
                {

                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("В массиве "+count+" положительных элементов");
            Console.WriteLine();

          

        }
    }
}
