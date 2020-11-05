using System;
using System.Text.RegularExpressions;

namespace HomeWork
{
    class Homework5
    {
        /// <summary>
        /// <para>1a</para>
        /// <para>Создать программу, которая будет проверять корректность ввода логина.</para>
        /// <para>Корректным логином будет строка от 2 до 10 символов, 
        /// содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой</para>
        /// </summary>
        /// <param name="login"></param>
        /// <returns>true if the login is correct</returns>
        public static bool CheckLoginA(String login)
        {
            if(!(2 <= login.Length && login.Length <= 10))
            {
                return false;
            }

            login = login.ToLower();
            for (int i = 0; i < login.Length; i++)
            {
                if (i == 0)
                {
                    if (
                        !(login[i] >= 'a' && login[i] <= 'z')
                    )
                    {
                        return false;
                    }
                } 
                else
                {
                    if (
                        !(
                            (login[i] >= 'a' && login[i] <= 'z') 
                            || (login[i] >= '0' && login[i] <= '9')
                        )
                    )
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// <para>1b</para>
        /// </summary>
        /// <param name="login"></param>
        /// <returns>true if the login is correct</returns>
        public static bool CheckLoginB(String login)
        {
            Regex pattern = new Regex(@"\A([a-z]{1})[a-z0-9]{1,9}\z");
            return pattern.IsMatch(login.ToLower());
        }

        /// <summary>
        /// Method for testing of task 1
        /// </summary>
        public static void TestLogin()
        {
            Console.WriteLine(Homework5.CheckLoginA("hello"));
            Console.WriteLine(Homework5.CheckLoginA("hELlo3"));
            Console.WriteLine(Homework5.CheckLoginA("hEl2lo"));
            Console.WriteLine(Homework5.CheckLoginA("He1llo"));
            Console.WriteLine(Homework5.CheckLoginA("0hello"));

            Console.WriteLine(Homework5.CheckLoginB("hello"));
            Console.WriteLine(Homework5.CheckLoginB("hELlo1"));
            Console.WriteLine(Homework5.CheckLoginB("helL0o"));
            Console.WriteLine(Homework5.CheckLoginB("hello1"));
            Console.WriteLine(Homework5.CheckLoginB("0hello"));

            Support.Pause();
        }
    }

}
