﻿using System;

namespace HomeWork
{
    /// <summary>
    /// <para> Author: Vinogradov Vyacheslav </para>
    /// <para>A class with support methods for homework</para>
    /// <para>*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).</para>
    /// </summary>
    class Support
    {
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
