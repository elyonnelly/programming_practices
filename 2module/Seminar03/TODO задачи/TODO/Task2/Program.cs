﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Task2
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            StaffMember[] staff = new StaffMember[8];

            for (int i = 0; i < staff.Length; i++)
            {
                Console.WriteLine(staff[i]);
            }
        }

        //TODO сделать метод GenerateStaff2, генерирующий работника со случайнымим значениями параметров.
        // зарплата от -1000 до 1000, имя - случайный набор букв латинского алфавита, должность равновероятно босс или рабочий
    }
}
