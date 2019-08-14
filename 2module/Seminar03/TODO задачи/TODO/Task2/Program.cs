using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
/*
 * Создать массив элементов типа StaffMember и вывести о них информацию
 */
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

        //TODO сделать метод GenerateStaff, генерирующий работника со случайнымим значениями параметров.
        // зарплата от -1000 до 1000, имя - случайный набор букв латинского алфавита, должность равновероятно босс или рабочий
    }
}
