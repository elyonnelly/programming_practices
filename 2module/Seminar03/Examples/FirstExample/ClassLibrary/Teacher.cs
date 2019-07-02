using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher
    {
        public Teacher(int age, string name):this(age,name,"Junior")
        {
        }

        public Teacher(int age, string name, string degree)
        {
            Age = age;
            Name = name;
            Degree = degree;
        }
        public string GetInfo() => $"Name: {Name}\nAge: {Age}\tDegree: {Degree}";

        int Age { get; set; }//инкапсуляция ради инкапсуляции
        string Name { get; set; }
        string Degree { get; set; }
    }
}
