using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rnd
    {
        /// <summary>
        /// создание рандомного имени
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static string CreateName(Random rnd)
        {
            string name = "";
            name += (char)rnd.Next('A', 'Z');
            for (int i = 0; i < rnd.Next(5, 15); i++)
            {
                name += (char)rnd.Next('a', 'z');//обратите внимание на работу char`ов
            }
            return name;
        }

        /// <summary>
        /// метод который выдает пол студента
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static string GetSex(Random rnd)
        {
            if (rnd.Next(0, 2) == 1)
            {
                return "Male";
            }
            else
                return "Female";
        }

        /// <summary>
        /// метод выдающий степень учителя
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static string GetDegree(Random rnd)
        {
            int rnk = rnd.Next(0, 2);
            if (rnk == 0)
            {
                return "Middle";
            }
            else
            {
                return "Senior";
            }
        }
    }
}
