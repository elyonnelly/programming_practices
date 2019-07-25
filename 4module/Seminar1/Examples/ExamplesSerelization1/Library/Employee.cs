using System;

namespace Library
{
    [Serializable]
    public class Employee
    {
        public string Name { get; private set; }
        double skill;
        public double Skill
        {
            get => skill;
            private set
            {
                if (value < 0 || value > 10) throw new Ovverrun("Способности человека оцениваются в промежутке от 0 до 10");//создание собственного исключения
                skill = value;
            }
        }
        int age;

        public Employee(string name, double skill, int age)
        {
            Name = name;
            Skill = skill;
            Age = age;
        }

        public int Age
        {
            get => age;
            private set
            {
                //реализация свобвенного исключения правая кнопка мыши, быстродецсвия рефакторинг, создать собсвенное исключение
                if (value < 18 || value > 65) throw new Ovverrun("Человек должен быть совершеннолетним и не пенсионером");
                age = value;
            }
        }

        public override string ToString() => $"Name : {Name}, Age : {Age}, Skill: {Skill:f3}";

    }
}
