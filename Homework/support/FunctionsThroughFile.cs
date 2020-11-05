using System;
using System.Collections.Generic;
using System.IO;
using static HomeWork.Support;

namespace HomeWork.support
{
    class FunctionsThroughFile
    {
        private static Dictionary<String, FuncX> functions = new Dictionary<String, FuncX>
        {
            { "sin", SinX },
            { "cos", CosX },
            { "sqrt", SqrtX },
            { "exp", ExpX }
        };

        public static FuncX GetFunctions(String key)
        {
            return functions[key.ToLower()];
        }

        private static double SinX(double x)
        {
            return Math.Sin(x);
        }

        private static double CosX(double x)
        {
            return Math.Cos(x);
        }

        private static double SqrtX(double x)
        {
            return Math.Sqrt(x);
        }

        private static double ExpX(double x)
        {
            return Math.Exp(x);
        }

        /// <summary>
        /// <para>2</para>
        /// <para>Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.</para>
        /// </summary>
        /// <param name="f">func for value calculation</param>
        /// <param name="fileName">filename to write values</param>
        /// <param name="aStart">start of a value</param>
        /// <param name="aStop">stop of a value</param>
        /// <param name="step">step of change a value</param>
        public static void SaveResults(FuncX f, string fileName, double aStart, double aStop, double step)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    for (double a = aStart; a <= aStop; a += step)
                    {
                        bw.Write(f(a));
                        if ((aStop - aStart) % step != 0 && (a + step) > aStop)
                        {
                            bw.Write(f(aStop));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// <para>2b</para>
        /// <para>Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.</para>
        /// <para>Переделать функцию Load, чтобы она возвращала массив считанных значений. </para>
        /// <para>Пусть она возвращает минимум через параметр (с использованием модификатора out)</para>
        /// </summary>
        /// <param name="f">func for value calculation</param>
        /// <param name="fileName">filename to write values</param>
        /// <param name="funcRes">result of f function</param>
        /// <returns>all values from file (see 'SaveResults' method)</returns>
        public static double[] Load(FuncArX f, string fileName, out double funcRes, FuncArXInterval ff = null, int startInt = 0, int stopInt = 0)
        {
            double[] results;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader bw = new BinaryReader(fs))
                {
                    results = new double[fs.Length / sizeof(double)];
                    for (int i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        results[i] = bw.ReadDouble();
                    }
                }
                funcRes = ff == null ? f(results) : ff(f, results, startInt, stopInt);
            }
            return results;
        }

        /// <summary>
        /// <para>2a</para>
        /// <para>Сделать меню с различными функциями и представить пользователю выбор, 
        /// для какой функции и на каком отрезке находить минимум. </para>
        /// <para>Использовать массив (или список) делегатов, в котором хранятся различные функции</para>
        /// </summary>
        /// <param name="f">func for value calculation</param>
        /// <param name="min">out param for min value</param>
        /// <param name="a">start of a value</param>
        /// <param name="b">stop of a value</param>
        /// <param name="step">step of change a value</param>
        /// <param name="startInt">start index for search min value</param>
        /// <param name="stopInt">stop index for search min value</param>
        /// <returns>all values from file (see 'SaveResults' method)</returns>
        public static double[] SearchMin(FuncX f, out double min, double a, double b, double step=0.5, int startInt = 0, int stopInt = 0)
        {
            String fn = "res.txt";

            SaveResults(f, fn, a, b, step);
            return Load(Min, fn, out min, FunkWithInterval, startInt, stopInt);
        }

        private static double Min(double[] ar)
        {
            double min = double.MaxValue;

            foreach (double i in ar)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }
    }
}
