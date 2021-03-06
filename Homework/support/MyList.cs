﻿using System;
using System.Collections;

namespace HomeWork
{
    /// <summary>
    /// <para>3</para>
    /// <para>Дописать класс для работы с одномерным массивом.</para>
    /// </summary>
    class MyList
    {
        private int[] array;
        public int Size { get; private set; }
        private int index;

        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        /// <summary>
        /// <para>Return copy of array as int[]</para>
        /// </summary>
        public int[] Array
        {
            get
            {
                int[] res = new int[this.Size];
                this.array.CopyTo(res, 0);

                return res;
            }
        }

        /// <summary>
        /// <para>Создать свойство Sum, которое возвращает сумму элементов массива.</para>
        /// </summary>
        public int Sum
        {
            get
            {
                int res = 0;
                foreach (int el in array)
                {
                    res += el;
                }

                return res;
            }
        }

        /// <summary>
        /// <para>свойство MaxCount, возвращающее количество максимальных элементов.</para>
        /// </summary>
        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = array[0];

                foreach (int i in array)
                {
                    max = i > max ? i : max;
                }

                foreach (int i in array)
                {
                    count = i == max ? count + 1 : count;
                }

                return count;
            }
        }

        /// <summary>
        /// <para>Реализовать конструктор, создающий массив определенного размера и 
        /// заполняющий массив числами от начального значения с заданным шагом. </para>
        /// </summary>
        /// <param name="size"> size of array</param>
        /// <param name="start">start position for value of elements</param>
        /// <param name="step">step of change for values of array</param>
        public MyList(int size, int start = 0, int step = 1)
        {
            this.Size = size;
            array = new int[size];
            for (int i = 0, j = start; i < size; i++, j += step)
            {
                array[i] = j;
            }
        }

        public MyList()
        {
            Size = 1;
            index = 0;
            array = new int[Size];
        }

        /// <summary>
        /// Add new value to inner array
        /// </summary>
        /// <param name="value">next value to array</param>
        public void Add(int value)
        {
            if (index == Size)
            {
                Resize();
            }
            array[index++] = value;
        }

        /// <summary>
        /// <para>метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива 
        /// (старый массив, остается без изменений).</para>
        /// </summary>
        /// <returns>new int array with inversed sign of values</returns>
        public int[] Inverse()
        {
            int[] res = Array;

            for (int i = 0; i < Size; i++)
            {
                res[i] = res[i] * (-1);
            }

            return res;
        }

        /// <summary>
        /// <para>метод Multi, умножающий каждый элемент массива на определённое число.</para>
        /// </summary>
        /// <param name="num"></param>
        public void Multi(int num)
        {
            for (int i = 0; i < Size; i++)
            {
                array[i] = array[i] * num;
            }
        }

        /// <summary>
        /// <para>Resize inner array, add 1 to max Size</para>
        /// </summary>
        private void Resize()
        {
            int[] res = new int[Size + 1];
            array.CopyTo(res,0);
            array = res;
            Size++;
        }
    }
}