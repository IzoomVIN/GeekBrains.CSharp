using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork
{
    /// <summary>
    /// <para>Создайте структуру Account, содержащую Login и Password.</para>
    /// </summary>
    struct Account
    {
        public String Login { get => Login ?? ""; private set => Login = value; }
        public String Password { get => Password ?? ""; private set => Password = value; }

        public Account(String login, String password)
        {
            Login = login;
            Password = password;
        }
    }

    class Homework4
    {
        public void CheckPAFF()
        {
            String path = "C:\\Users\\Slava\\Desktop\\arr.txt";
            foreach (int num in StaticArrayClass.ParseFromFile(path))
            {
                Console.Write(num + " ");
            }

            Support.Pause();
        }

        /// <summary>
        /// <para>4</para>
        /// <para>Решить задачу с логинами из урока 2, 
        /// только логины и пароли считать из файла в массив.</para>
        /// </summary>
        /// <param name="path">path to file with account data</param>
        /// <returns></returns>
        public bool LogIn(String path)
        {
            Account acc = ReadFile(path);

            if (acc.Login.ToLower().Equals("root"))
            {
                if (acc.Password.Equals("GeekBrains"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("wrong password!");
                }
            }
            else
            {
                Console.WriteLine("Unknown user!");
            }

            return false;
        }

        /// <summary>
        /// <para>read params from file</para>
        /// </summary>
        /// <param name="path">path to file with parameters</param>
        /// <returns>dict of params if good else write error to console and return null</returns>
        private Account ReadFile(String path)
        {
            
            StreamReader sr;
            String login = "";
            String password = "";

            try
            {
                sr = new StreamReader(path);
                String str;

                while ((str = sr.ReadLine()) != null)
                {
                    String[] line = str.Split('=');
                    for (int i =0; i< line.Length; i++)
                    {
                        line[i] = line[i].Replace(" ", "");
                    }

                    if(line.Length != 2)
                    {
                        Console.WriteLine($"Error, unregister line: \"{str}\"");
                        return new Account();
                    }


                    switch (line[0])
                    {
                        case "login":
                            login = line[1];
                            break;
                        case "password":
                            password = line[1];
                            break;
                        default:
                            Console.WriteLine($"Error, unregister param: \"{line[0]}\"");
                            break;
                    }
                }

                sr.Close();

                return new Account(login, password);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return new Account();
            }
        }
    }
}
