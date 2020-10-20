using System;
using System.IO;

namespace HomeWork
{
    /// <summary>
    /// <para>2</para>
    /// <para>Реализуйте задачу 1 в виде статического класса StaticClass</para>
    /// </summary>
    static class StaticArrayClass
    {

        /// <summary>
        /// <para>1 - 2a</para>
        /// <para>Заполняет случайными числами от –10 000 до 10 000 включительно.</para>
        /// </summary>
        /// <param name="ar">references on array for filling</param>
        public static void FillingTheArray(ref int[] ar)
        {
            Random r = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = r.Next(-10_000, 10_000);
            }
        }

        /// <summary>
        /// <para>1</para>
        /// <para>найти количество пар элементов массива, в которых только одно число делится на 3</para>
        /// </summary>
        /// <param name="ar">array for research</param>
        /// <returns>count of this pairs</returns>
        public static int NumberOfPairs(int[] ar)
        {
            int count = 0;

            for(int i = 0, ii = 1; ii < ar.Length; i++,ii++)
            {
                if((ar[i] % 3 == 0) ^ (ar[ii] % 3 == 0))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// <para>2b-2c</para>
        /// <para>статический метод для считывания массива из текстового файла.</para>
        /// </summary>
        /// <param name="path">Full path to file in system</param>
        /// <returns>Массив целых чисел</returns>
        public static int[] ParseFromFile(String path)
        {
            MyList list = new MyList();
            StreamReader sr;
            try
            {
                sr = new StreamReader(path);
                String str;
                
                while ((str = sr.ReadLine()) != null) {
                    if (int.TryParse(str, out int x)) 
                    { 
                        list.Add(x); 
                    }
                }

                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                
                int[] res = new int[10];
                FillingTheArray(ref res);

                return res;
            }

            return list.Array;
        }
    }
}
