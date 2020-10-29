using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork
{
    /// <summary>
    /// <para>2 - 3</para>
    /// <para>Разработать статический класс Message, содержащий следующие статические методы для обработки текста</para>
    /// </summary>
    static class Message
    {

        /// <summary>
        /// <para>2a</para>
        /// <para>Вывести только те слова сообщения,  которые содержат не более n букв.</para>
        /// </summary>
        /// <param name="text">text for research</param>
        /// <param name="maxLenght">max char for words</param>
        public static void WriteWordsWithLenghtLowN(String text, int maxLenght)
        {
            String[] wordArr = Cleaning(text).Split(' ');
            foreach (String word in wordArr)
            {
                if (word.Length <= maxLenght)
                {
                    Console.WriteLine(word);
                }
            }
        }

        /// <summary>
        /// <para>2b</para>
        /// <para>Удалить из сообщения все слова, которые заканчиваются на заданный символ</para>
        /// </summary>
        /// <param name="text">text for research</param>
        /// <param name="endChar">trigger for delete words? end char</param>
        public static void DeleteWordsEndCharFromText(ref String text, char endChar)
        {
            Regex pattern = new Regex($@"{endChar}\z");

            foreach (String word in ((String)text.Clone()).Split(' '))
            {
                if (pattern.IsMatch(word))
                {
                    text = text.Replace(word, "");
                }
            }
        }

        /// <summary>
        /// <para>2v</para>
        /// <para>Найти самое длинное слово сообщения.</para>
        /// </summary
        /// <param name="text">text for research</param>
        /// <returns>First word with max lenght</returns>
        public static String getGreatestWord(String text)
        {
            int maxLenght = 0;
            foreach (String word in text.Split(' '))
            {
                if (maxLenght < word.Length)
                {
                    maxLenght = word.Length;
                }
            }

            foreach (String word in text.Split(' '))
            {
                if (maxLenght == word.Length)
                {
                    return word;
                }
            }

            return null;
        }

        /// <summary>
        /// <para>2g</para>
        /// <para>Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.</para>
        /// </summary
        /// <param name="text">text for research</param>
        /// <returns>String with words that have the lenght equals the max lenght</returns>
        public static String getGreatestWordsStr(String text)
        {
            int maxLenght = 0;
            foreach (String word in text.Split(' '))
            {
                if (maxLenght < word.Length)
                {
                    maxLenght = word.Length;
                }
            }

            StringBuilder res = new StringBuilder();

            foreach (String word in text.Split(' '))
            {
                if (maxLenght == word.Length)
                {
                    res.Append(word).Append(" ");
                }
            }

            return res.ToString();
        }

        /// <summary>
        /// <para>2d</para>
        /// <para>***Создать метод, который производит частотный анализ текста.</para>
        /// <para>В качестве параметра в него передается массив слов и текст, 
        /// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.</para>
        /// <para>Здесь требуется использовать класс Dictionary.</para>
        /// </summary
        /// <param name="text">text for research</param>
        /// <returns>Dictionary wiht words as keys and their numbers in text as values</returns>
        public static Dictionary<String, int> FrequencyAnalysis(String text)
        {
            Dictionary<String, int> freq = new Dictionary<String, int>();

            foreach (String word in Cleaning(text).Split(' '))
            {
                String clearWord = word.Replace(" ", "");
                if (freq.ContainsKey(clearWord))
                {
                    freq[clearWord] += 1;
                }
                else
                {
                    freq.Add(clearWord, 1);
                }
            }

            return freq;

            //List<KeyValuePair<String, int>> sortedDict = freq.ToList();
            //sortedDict.Sort((pair1, pair2) => pair1.Value > pair2.Value ? -1 : pair1.Value == pair2.Value ? 0 : 1);

            //foreach (KeyValuePair<String, int> kv in sortedDict)
            //{
            //    Console.WriteLine($"{kv.Key} : {kv.Value}");
            //}
        }

        /// <summary>
        /// <para>3</para>
        /// <para>*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.</para>
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>true if chars and their numbers are equals in both strings</returns>
        public static bool CheckStrings(String value1, String value2)
        {
            if (value1.Length != value2.Length)
            {
                return false;
            }

            Dictionary<Char, int> dictVal1 = FrequencyAnalysisByChar(value1);
            Dictionary<Char, int> dictVal2 = FrequencyAnalysisByChar(value2);

            foreach (Char key in dictVal1.Keys)
            {
                if (!dictVal2.ContainsKey(key))
                {
                    return false;
                }
                if (dictVal2[key] != dictVal1[key])
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<Char, int> FrequencyAnalysisByChar(String text)
        {
            Dictionary<Char, int> freq = new Dictionary<Char, int>();

            foreach (Char i in text)
            {
                if (freq.Keys.Contains(i))
                {
                    freq[i] += 1;
                }
                else
                {
                    freq.Add(i, 1);
                }
            }

            return freq;
        }

            /// <summary>
            /// inner function for cleaning of the text
            /// </summary>
            /// <param name="text">your text</param>
            /// <returns>your text without smth chars</returns>
            private static String Cleaning(String text)
        {
            return text.Replace(';', ' ').Replace(':', ' ')
                        .Replace('\'', ' ').Replace('\"', ' ')
                        .Replace('<', ' ').Replace('>', ' ')
                        .Replace('.', ' ').Replace(',', ' ')
                        .Replace('{', ' ').Replace('}', ' ')
                        .Replace('\\', ' ').Replace('|', ' ')
                        .Replace('[', ' ').Replace(']', ' ')
                        .Replace('/', ' ').Replace('?', ' ')
                        .Replace("  ", " ");
        }
    }
}
