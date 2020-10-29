using HomeWork.support;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using static HomeWork.Support;

namespace HomeWork.homeworks
{
    class HomeWork6
    {
        private static double AX2(double a, double x)
        {
            return a * x * x;
        }

        private static double ASinX(double a, double x)
        {
            return a * Math.Sin(x);
        }

        /// <summary>
        /// <para>Изменить программу вывода таблицы функции так, 
        /// чтобы можно было передавать функции типа double (double, double).</para>
        /// </summary>
        /// <param name="f">function for value calcuation</param>
        /// <param name="x">x value</param>
        /// <param name="aStart">start of a value</param>
        /// <param name="aStop">stop of a value</param>
        /// <param name="step">step of change a value</param>
        /// <returns></returns>
        private static String WriteTable(FuncAX f, double x, double aStart, double aStop, double step=0.5)
        {
            StringBuilder res = new StringBuilder();
            res.Append($"x = {x}\n");
            void Add(double innerA) 
            {
                res.Append($"|\t{innerA}\t|\t{f(innerA, x):F2}\t|\n");
                res.Append("---------------------------------\n");
            }

            for (double a = aStart; a<=aStop; a += step)
            {
                Add(a);
                if ((aStop-aStart)%step != 0 && (a + step) > aStop)
                {
                    Add(aStop);
                }
            }

            return res.ToString();
        }

        /// <summary>
        /// <para>Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).</para>
        /// </summary>
        public static void CheckWriteTable() 
        {
            Console.WriteLine(WriteTable(AX2, 1.5, 1.2, 1.4));
            Pause();
            Console.WriteLine(WriteTable(AX2, 1.5, 1, 2));
            Pause();

            Console.WriteLine(WriteTable(ASinX, 1.5, 1, 2));
            Pause();
            Console.WriteLine(WriteTable(ASinX, 1.5, 1, 2, 0.1));
            Pause();
        }

        /// <summary>
        /// <para>2a</para>
        /// <para>Сделать меню с различными функциями и представить пользователю выбор, 
        /// для какой функции и на каком отрезке находить минимум. </para>
        /// <para>Использовать массив (или список) делегатов, в котором хранятся различные функции</para>
        /// </summary>
        public static void MenuFunctions()
        {
            double start, stop, step, min;
            int startInt, stopInt;
            String func;
            Console.WriteLine("Enter double values:");
            Console.Write("Start value = ");
            start = double.Parse(Console.ReadLine());
            Console.Write("Stop value = ");
            stop = double.Parse(Console.ReadLine());
            Console.Write("Step of value change = ");
            step = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter functions for calculated:");
            Console.WriteLine("sin - Sin of x");
            Console.WriteLine("cos - Cos of x");
            Console.WriteLine("sqrt - sqrt of x");
            Console.WriteLine("exp - exp ^ x");
            func = Console.ReadLine();

            Console.WriteLine("\nEnter index interval of min search:");
            Console.Write("Start value = ");
            startInt = int.Parse(Console.ReadLine());
            Console.Write("Stop value = ");
            stopInt = int.Parse(Console.ReadLine());



            FunctionsThroughFile.SearchMin(FunctionsThroughFile.GetFunctions(func),
                                            out min, start, stop, step,
                                            startInt, stopInt);

            Console.WriteLine($"\n\nMin value of {func}(x) where x from {start} to {stop} on index interval {startInt} - {stopInt} = {min}");
        } 
    }
}
