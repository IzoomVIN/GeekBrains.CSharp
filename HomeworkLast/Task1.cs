using System;
using System.Reflection;

namespace HomeworkLast
{
    class Task1
    {
        /// <summary>
        /// <para>1</para>
        /// <para>С помощью рефлексии выведите все свойства структуры DateTime</para>
        /// </summary>
        public static void GetProperties()
        {
            DateTime obj = new DateTime();
            foreach( PropertyInfo inf in obj.GetType().GetProperties()) 
            {
                Console.WriteLine($"{inf.Name} : {inf.PropertyType}");
            }

            Console.ReadLine();
        }
    }
}
