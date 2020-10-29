using System;

namespace HomeWork
{
    /// <summary>
    /// <para> Author: Vinogradov Vyacheslav </para>
    /// <para>A class with support methods for homework</para>
    /// <para>*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).</para>
    /// </summary>
    class Support
    {
        public delegate double FuncAX(double a, double x);
        public delegate double FuncX(double x);
        public delegate double FuncArX(double[] x);
        public delegate double FuncArXInterval(FuncArX f, double[] x, int start, int stop);

        public static double FunkWithInterval(FuncArX f, double[] x, int start=0, int stop=0)
        {
            if ((start == 0 && stop == 0) || stop >= x.Length)
            {
                return f(x);
            }
            else
            {
                int[] ind = new int[start - stop + 1];
                for (int i = 0, j = start; i < ind.Length; i++, j++)
                {
                    ind[i] = j;
                }
                return f((double[])x.GetValue(ind));
            }
        }

        public static long AskWeight()
        {
            Console.Write("Weight: ");
            return long.Parse(Console.ReadLine());
        }

        public static int AskHeight()
        {
            Console.Write("Height: ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Print ${message} to console and return value from user
        /// </summary>
        /// <param name="message">text for console</param>
        /// <returns></returns>
        public static String GetFromUser(String message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        public static void Pause()
        {
            Console.ReadKey();
            Console.WriteLine("\n\n");
        }
    }
}
