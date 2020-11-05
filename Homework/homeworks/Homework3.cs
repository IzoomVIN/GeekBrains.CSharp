using System;
using static HomeWork.Support;

namespace HomeWork
{
    /// <summary>
    /// <para>1a</para>
    /// <para>Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    /// Продемонстрировать работу структуры</para>
    /// </summary>
    struct ComplexStruct
    {
        private double a;
        private double b;

        public ComplexStruct(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public static ComplexStruct operator +(ComplexStruct ts, ComplexStruct other)
        {
            return new ComplexStruct(
                other.a + ts.a, 
                other.b + ts.b
                );
        }

        public static ComplexStruct operator -(ComplexStruct ts, ComplexStruct other)
        {
            return new ComplexStruct(
                ts.a - other.a, 
                ts.b - other.b
                );
        }

        public override string ToString()
        {
            if (b >= 0)
            {
                return $"{this.a} + {this.b}i";
            } else
            {
                return $"{this.a} - {this.b*(-1)}i";
            }
        }
    }

    /// <summary>
    /// <para>1b</para>
    /// <para>Дописать класс Complex, добавив методы вычитания и произведения чисел. 
    /// Проверить работу класса.</para>
    /// </summary>
    class ComplexClass
    {
        private double a;
        private double b;

        public ComplexClass(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public ComplexClass Add(ComplexClass other)
        {
            return new ComplexClass(
                other.a + this.a, 
                other.b + this.b
                );
        }

        public ComplexClass Subtract(ComplexClass other)
        {
            return new ComplexClass(
                this.a - other.a, 
                this.b - other.b
                );
        }

        public ComplexClass Multiply(ComplexClass other)
        {
            return new ComplexClass(
                this.a * other.a - this.b * other.b, 
                this.a * other.b - this.b * other.a
                );
        }


        public override string ToString()
        {
            if (b >= 0)
            {
                return $"{this.a} + {this.b}i";
            }
            else
            {
                return $"{this.a} - {this.b * (-1)}i";
            }
        }
    }

    /// <summary>
    /// <para>3</para>
    /// <para>Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. </para>
    /// <para>Предусмотреть методы сложения, вычитания, умножения и деления дробей. </para>
    /// </summary>
    class FractionalClass
    {
        private int den;

        /// <summary>
        /// <para>Добавить свойства типа int для доступа к числителю и знаменателю</para>
        /// </summary>
        public int Nom { get; set; }
        public int Den
        {
            get
            {
                return den;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }

                den = value;
            }
        }

        /// <summary>
        /// <para>Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа</para>
        /// </summary>
        public double Fractional => Nom / den;

        public static FractionalClass operator +(FractionalClass First, FractionalClass Second)
        {
            FractionalClass Res = new FractionalClass();
            if (First.den != Second.den)
            {
                Res.Den = First.den * Second.den;
                Res.Nom = (First.Nom * Second.den) + (Second.Nom * First.den);
            }
            else
            {
                Res.Den = First.den;
                Res.Nom = First.Nom + Second.Nom;
            }

            return Res;
        }

        public static FractionalClass operator -(FractionalClass First, FractionalClass Second)
        {
            FractionalClass Res = new FractionalClass();
            if (First.den != Second.den)
            {
                Res.Den = First.den * Second.den;
                Res.Nom = (First.Nom * Second.den) - (Second.Nom * First.den);
            }
            else
            {
                Res.Den = First.den;
                Res.Nom = First.Nom - Second.Nom;
            }

            return Res;
        }

        public static FractionalClass operator *(FractionalClass First, FractionalClass Second)
        {
            FractionalClass Res = new FractionalClass();

            Res.den = First.den * Second.den;
            Res.Nom = First.Nom * Second.Nom;

            return Res;
        }

        public static FractionalClass operator /(FractionalClass First, FractionalClass Second)
        {
            FractionalClass Res = new FractionalClass();

            Res.Den = First.den * Second.Nom;
            Res.Nom = First.Nom * Second.den;
            

            return Res;
        }

        public override string ToString()
        {
            return $"{Nom}/{den}";
        }
    }

    class Homework3
    {
        private ComplexClass GetComplex(String name)
        {
            int re, im;

            Console.WriteLine($"Input complex number {name}:");
            Console.Write("Re = ");
            re = int.Parse(Console.ReadLine());
            Console.Write("Im = ");
            im = int.Parse(Console.ReadLine());

            return new ComplexClass(re, im);
        }

        private FractionalClass GetFractional(String name)
        {
            int nom, den;

            Console.WriteLine($"Input fractional number {name}:");
            Console.Write("Nom = ");
            nom = int.Parse(Console.ReadLine());
            Console.Write("Den = ");
            den = int.Parse(Console.ReadLine());

            FractionalClass res = new FractionalClass();
            res.Nom = nom;
            res.Den = den;
            return res;
        }

        private String Dialog(Object a, Object b, bool full = false)
        {
            Console.WriteLine($"\nEntered variables:\nA = {a}\nB = {b}");
            Console.WriteLine($"Enter action:");
            Console.WriteLine($"Add");
            Console.WriteLine($"Substract / Sub");
            Console.WriteLine($"Multiply / Mult\n");
            if (full) Console.WriteLine($"Division / Div\n");
            Console.Write("Action: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// <para>1v</para>
        /// <para>Добавить диалог с использованием switch демонстрирующий работу класса.</para>
        /// </summary>
        public void WorkOfComplexClass()
        {
            ComplexClass a, b;
            String action;

            a = GetComplex("A");
            b = GetComplex("B");

            action = Dialog(a,b);

            switch(action.ToLower())
            {
                case "add":
                    Console.WriteLine($"Result = {a.Add(b)}");
                    break;
                case "substract":
                case "sub":
                    Console.WriteLine($"Result = {a.Subtract(b)}");
                    break;
                case "multiply":
                case "mult":
                    Console.WriteLine($"Result = {a.Multiply(b)}");
                    break;
                default:
                    Console.WriteLine($"Unknown action :{action}");
                    break;
            }

            Pause();
        }

        /// <summary>
        /// <para>3</para>
        /// <para>Написать программу, демонстрирующую все разработанные элементы класса.</para>
        /// </summary>
        public void WorkOfFractional()
        {
            FractionalClass a, b;
            String action;

            a = GetFractional("A");
            b = GetFractional("B");

            action = Dialog(a,b,true);

            switch (action.ToLower())
            {
                case "add":
                    Console.WriteLine($"Result = {a + b}");
                    break;
                case "substract":
                case "sub":
                    Console.WriteLine($"Result = {a - b}");
                    break;
                case "multiply":
                case "mult":
                    Console.WriteLine($"Result = {a * b}");
                    break;
                case "division":
                case "div":
                    Console.WriteLine($"Result = {a / b}");
                    break;
                default:
                    Console.WriteLine($"Unknown action :{action}");
                    break;
            }

            Pause();
        }

        /// <summary>
        /// <para>2</para>
        /// <para>С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). </para>
        /// <para>Требуется подсчитать сумму всех нечётных положительных чисел. </para>
        /// <para>Сами числа и сумму вывести на экран, используя tryParse.</para>
        /// </summary>
        public void CustomSum()
        {
            int i = 0, sum = 0;

            while (true)
            {
                String read = Console.ReadLine();

                Console.WriteLine("Enter int numbers (0 for exit)");

                if (int.TryParse(read, out int number))
                {
                    if (number == 0)
                    {
                        break;
                    } 
                    else if (i % 2 != 0 && number > 0)
                    {
                        sum += number;
                    }
                    i++;
                } else
                {
                    Console.WriteLine($"Invalid value of int number: {read}");
                }
            }

            Console.WriteLine($"Sum = {sum}");

            Pause();
        }

        
    }
}
