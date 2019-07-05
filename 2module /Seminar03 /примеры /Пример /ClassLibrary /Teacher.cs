
namespace ClassLibrary
{
    public class Teacher
    {
        public Teacher(int age, string name) : this(age, name, "Junior")
        {
        }

        public Teacher(int age, string name, string degree)
        {
            Age = age;
            Name = name;
            Degree = degree;
        }
        public string GetInfo() => $"Name: {Name}\nAge: {Age}\tDegree: {Degree}";

        int Age { get;}
        string Name { get; }
        string Degree { get;}
    }
}
