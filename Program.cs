using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "C:\\Users\\Slava\\Desktop\\arr.txt";
            foreach (int num in StaticArrayClass.ParseFromFile(path))
            {
                Console.Write(num + " ");
            }

            Support.Pause();
        }
    }
}
