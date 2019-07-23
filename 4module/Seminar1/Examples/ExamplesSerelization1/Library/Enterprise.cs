using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public abstract class Enterprise
    {
        protected Enterprise(int numberOfDepartments, string name, string owner)
        {
            NumberOfDepartments = numberOfDepartments;
            Name = name;
            Owner = owner;
        }
        int numberifdepartments;
        public int NumberOfDepartments
        {
            get => numberifdepartments;
            private set
            {
                if (value < 0) throw new ArgumentException("Количество отделов не может быть отрицательным");
                numberifdepartments=value;
            }
        }
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public abstract void Recuit(Employee person);
        public abstract void Dismiss();
        public override string ToString() => $"Enterprise Name : {Name}, Owner : {Owner}, Number of departments : {NumberOfDepartments}";
    }
}
