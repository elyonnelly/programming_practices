using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
В одной секции занимаются люди,  у которых есть фамилия имя и отчество, причем фамилии у двух людей не повторяются
Необходимо написать программу, которая по фамилии человека возвращает его полное имя. Используйте словарь

 */

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            do { 
                List<string> Keys = new List<string>();
                Dictionary<string, string> Dict = new Dictionary<string, string>();
                string input = Console.ReadLine();
                while (input != "end")
                {
                    if (input.Split().Length != 3)
                        Console.WriteLine("Неверные данные");
                    else if (Keys.Contains(input.Split()[0]))
                        Console.WriteLine("Такой ключ уже был");
                    else
                    {
                        Keys.Add(input.Split()[0]);
                        Dict.Add(input.Split()[0], input);
                    }
                    input = Console.ReadLine();
                }
                input = Console.ReadLine();
                while (input != "end")
                {
                    if (Keys.Contains(input))
                        Console.WriteLine(Dict[input]);
                    else
                        Console.WriteLine("Такого ключа нет");
                    input = Console.ReadLine();
                }


            } while(Console.ReadKey(true).Key!= ConsoleKey.Enter);
            
        }
    }
}
