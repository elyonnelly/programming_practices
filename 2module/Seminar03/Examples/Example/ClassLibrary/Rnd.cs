using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rnd
    {
        public static Random rnd = new Random();

        /// <summary>
        /// создание рандомного имени
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static string CreateName()
        {
            string name = "";
            name += (char)rnd.Next('A', 'Z' + 1);
            int rnk = rnd.Next(5, 15);
            for (int i = 0; i < rnk; i++)
            {
                name += (char)rnd.Next('a', 'z' + 1);//обратите внимание на работу char`ов
            }
            return name;
        }

        /// <summary>
        /// метод который выдает пол студента
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static string GetSex() => rnd.Next(0, 2) == 1 ? "Male" : "Female";


        /// <summary>
        /// метод выдающий степень учителя
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static string GetDegree() => rnd.Next(0, 2) == 0 ? "Middle" : "Senior";

    }
}
