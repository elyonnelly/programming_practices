using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StaffMember
    {
        public StaffMember(int salary, string name, string position)
        {
            Salary = salary;
            Name = name;
            Position = position;
        }

        /*
         * TODO создать конструктор, принимающий два параметра - имя и должность, обращающийся к конструктору от трех
         * параметров через ключевое слово this (зарплату генерировать случайно)
         */

        public int Salary { get; private set; } //TODO добавить проверку на неотрицательность зарплаты, иначе зарплата 0
        
        public string Name { get; private set; } //TODO проверить что все символы в имени буквы и что первая буква заглавная
                                                 // иначе имя = Bill
        private string position;
        public string Position { get { return position; } private set
            {
                if (value == "Boss" || value == "Worker") position = value;
                else position = "Worker";
            } }

        public string GetInfo() => ""; //TODO
    }
}
