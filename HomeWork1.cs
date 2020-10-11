using System;
using static HomeWork.Support;

namespace HomeWork
{
    /// <summary>
    /// <para> Author: Vinogradov Vyacheslav </para>
    /// <para> First homework </para>
    /// </summary>
    class HomeWork1
    {

        private long AskWeight() 
        {
            Console.Write("Weight: ");
            return long.Parse(Console.ReadLine());
        }

        private int AskHeight() 
        {
            Console.Write("Height: ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// <para>1</para>
        ///<para>Написать программу «Анкета».
        ///Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
        ///В результате вся информация выводится в одну строчку:</para>
        ///<para>     а) используя склеивание;</para>
	    ///<para>     б) используя форматированный вывод;</para>
	    ///<para>     в) используя вывод со знаком $.</para>
        /// </summary>
        public void Form()
        {
            Console.Write("First Name: ");
            String firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            String lastName = Console.ReadLine();
            Console.Write("Years old: ");
            String years= Console.ReadLine();
            var weight = AskWeight();
            var height = AskHeight();

            Console.WriteLine();
            String result;

            #region form a
            result = lastName + " " + firstName + ", years: " + years + ", weight: " + weight + ", height: " + height;
            Console.WriteLine($"form a:\n{result}\n");
            #endregion

            #region form b
            result = String.Format("{0} {1}, years: {2}, weight: {3}, height: {4}", lastName, firstName, years, weight, height);
            Console.WriteLine($"form b:\n{result}\n");
            #endregion

            #region form c
            result = $"{lastName} {firstName}, years: {years}, weight: {weight}, height: {height}";
            Console.WriteLine($"form c:\n{result}\n");
            #endregion


            Pause();
        }

        ///<summary>
        ///<para>2</para>
        ///Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле 
        ///<para>I=m/(h*h); где:</para>
        ///<para>m — масса тела в килограммах,</para> 
        ///<para>h — рост в метрах.</para>
        public void BMI()
        {
            Console.WriteLine(
                $"{AskWeight()/Math.Pow(AskHeight(), 2)}"
                );
            Pause();
        }

        /// <summary>
        /// <para>3</para>
        /// <para>а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        /// по формуле </para>
        /// <para>r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). </para>
        /// <para>Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой); </para>
        /// </summary>
        public void Distance()
        {
            Console.Write("Enter coordinates of point 1:\n x = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter coordinates of point 2:\n x= ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"distance = {CalculateDistance(x1, y1, x2, y2):F2}");

            Pause();

        }

        /// <summary>
        /// <para>3</para>
        /// <para>б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.</para>
        /// </summary>
        /// <param name="x1">X координата точки 1</param>
        /// <param name="y1">Y координата точки 1</param>
        /// <param name="x2">X координата точки 2</param>
        /// <param name="y2">Y координата точки 2</param>
        /// <returns></returns>
        private double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        /// <summary>
        /// <para>4</para>
        /// <para>Написать программу обмена значениями двух переменных:</para>
        /// <para>а) с использованием третьей переменной;</para>
        /// </summary>
        public void SwapNumbersWithVar()
        {
            Console.Write("Enter number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.Write($"After swap:\n number A = {a}\n  number B = {b}");
            Pause();
        }

        /// <summary>
        /// <para>4</para>
        /// <para>Написать программу обмена значениями двух переменных:</para>
        /// <para>б) *без использования третьей переменной.</para>
        /// </summary>
        public void SwapNumbersWithoutVar()
        {
            Console.Write("Enter number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            int b = int.Parse(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;
            
            Console.Write($"After swap:\n number A = {a}\n number B = {b}");
            Pause();
        }

        /// <summary>
        /// <para>Написать программу, которая выводит на экран ваше имя, фамилию и город проживания</para>
        /// <para>*Сделать задание, только вывод организовать в центре экрана.</para>
        /// <para>**Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).</para>
        /// </summary>
        public void MyInformation()
        {
            String family = "First name: Vyacheslav";
            String name = "Last name: Vinogradov";
            String city = "City: Moscow";

            #region version b
            Print(family, (Console.BufferWidth / 2 - (family.Length / 2)), 13);
            Print(name, (Console.BufferWidth / 2 - (name.Length / 2)), 14);
            Print(city, (Console.BufferWidth / 2 - (city.Length / 2)), 15);
            #endregion

            Pause();

            #region version a
            Print(family, (Console.BufferWidth / 2 - (family.Length/2)), (Console.BufferHeight / 2 - 1));
            Print(name, (Console.BufferWidth / 2 - (name.Length / 2)), (Console.BufferHeight / 2));
            Print(city, (Console.BufferWidth / 2 - (city.Length / 2)), (Console.BufferHeight / 2 + 1));

            Console.SetCursorPosition(0, (Console.BufferHeight / 2 + 15));
            #endregion

            Pause();
        }


    }
}
