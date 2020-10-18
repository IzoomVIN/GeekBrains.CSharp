using System;
using static HomeWork.Support;
namespace HomeWork
{
    /// <summary>
    /// <para> Author: Vinogradov Vyacheslav </para>
    /// <para> Second homework </para>
    /// </summary>
    class Homework2
    {
        /// <summary>
        /// <para>1</para>
        /// <para>Написать метод, возвращающий минимальное из трёх чисел</para>
        /// </summary>
        public void MinOfThree()
        {
            int a = int.Parse(GetFromUser("Enter number a:"));
            int b = int.Parse(GetFromUser("Enter number b:"));
            int c = int.Parse(GetFromUser("Enter number c:"));

            int min = (a < b) ? a : b;
            min = (min < c) ? min : c;

            Console.WriteLine($"Minimum number {min}");
            Pause();
        }

        /// <summary>
        /// <para>2</para>
        /// <para>Написать метод подсчета количества цифр числа.</para>
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int NumberOfDigitsInNumber(int number)
        {
            int count = 1;

            while ((number / 10) != 0)
            {
                count += 1;
                number = number / 10;
            }

            return count;
        }

        /// <summary>
        /// <para>3</para>
        /// <para>С клавиатуры вводятся числа, пока не будет введен 0.</para>
        /// <para>Подсчитать сумму всех нечетных положительных чисел.</para>
        /// </summary>
        public void SumOfOddNumbers()
        {
            int sum = 0;
            int number;
            Console.WriteLine("Enter number (0 for exit):");
            do
            {
                number = int.Parse(Console.ReadLine());
                sum = (number > 0 && number % 2 != 0) ? sum + number : sum;
            } while (number != 0);

            Console.WriteLine($"Sum of odd numbers = {sum}");

            Pause();
        }

        /// <summary>
        /// <para>4</para>
        /// <para>Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.</para>
        /// <para>На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).</para>
        /// <para>Используя метод проверки логина и пароля, написать программу: </para>
        /// <para>пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.</para> 
        /// <para>С помощью цикла do while ограничить ввод пароля тремя попытками.</para>
        /// </summary>
        public bool LogIn()
        {
            int i = 3;
            while (i > 0)
            {
                if (GetFromUser("Enter login please:").ToLower().Equals("root"))
                {
                    if (GetFromUser("Enter password please:").Equals("GeekBrains"))
                    {
                        return true;
                    } else
                    {
                        Console.WriteLine("wrong password!");
                    }
                } else
                {
                    Console.WriteLine("Unknown user!");
                }
                Console.WriteLine($"{--i} attempts left"); 
            }
            return false;    
        }

        /// <summary>
        /// <para>5</para>
        /// <para>Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает:</para>
        /// <para>а) Нужно ли человеку похудеть, набрать вес или всё в норме.</para>
        /// <para>б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.</para>
        /// </summary>
        public void BMIwithRec()
        {
            double weight = AskWeight();
            double height = (double) AskHeight()/100;
            double bmi = weight / Math.Pow(height, 2);

            String result = $"BMI = {bmi:F1};";

            if (bmi < 18.5)
            {
                result += " Lack of weight.";
                result += $"\nRecommendation: gain {GetWeightDelta(weight, height, 19):F1} kg of weight";
            } else if (bmi > 24.9)
            {
                result += " Overweight";
                result += $"\nRecommendation: lose weight by {GetWeightDelta(weight, height, 24):F1} kg.";
            } else
            {
                result += " Normal weight";
            }

            Console.WriteLine(result);

            Pause();
        }

        /// <summary>
        /// <para>6</para>
        /// <para>*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.</para>
        /// <para>«Хорошим» называется число, которое делится на сумму своих цифр.</para>
        /// <para>Реализовать подсчёт времени выполнения программы, используя структуру DateTime.</para>
        /// </summary>
        public void GoodNumbers()
        {
            int count = 0;
            DateTime start = new DateTime();
            for (int i = 1; i <= 1000000000; i++)
            {
                int sum = 0;
                int currentNum = i;
                while(currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }

                if (i % sum == 0)
                {
                    count++;
                }
            }

            DateTime end = new DateTime();
            Console.WriteLine($"count = {count}");
            Console.WriteLine($"time = {start - end}");
            Pause();
        }

        /// <summary>
        /// <para>7a</para>
        /// <para>Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public int AllNumFromAtoB(int a, int b)
        {
            if (a < b)
            {
                Console.Write($"{a}..");
                return AllNumFromAtoB(a + 1, b);
            }
            else
            {
                Console.Write($"{a}");
            }

            Pause();
            return 0;
        }

        /// <summary>
        /// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum"></param>
        public int SumNumFromAtoB(int a, int b, int sum = 0)
        {
            if (a < b)
            {
                sum += a;
                return SumNumFromAtoB(a + 1, b, sum);
            }
            else
            {
                Console.Write($"sum = {sum+a}");
            }

            Pause();
            return 0;
        }

        private double GetWeightDelta(double weight, double height, double bmi)
        {
            return Math.Abs((bmi * Math.Pow(height, 2)) - weight);
        }

    }
}
