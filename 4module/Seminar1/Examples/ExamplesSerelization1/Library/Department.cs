using System;
using System.Collections.Generic;

namespace Library
{
    [Serializable]
    public class Department : Enterprise
    {
        public string DepartmentName { get; private set; }
        public List<Employee> Staff
        {
            get => staff;
            private set
            {
                staff = value == null ? new List<Employee>() : value;//чтобы не падала ошибка в методах
            }
        }

        List<Employee> staff;

        public Department(int numberOfDepartments, string name, string owner, List<Employee> staff, string departmentname)
            : base(numberOfDepartments, name, owner)
        {
            DepartmentName = departmentname;
            Staff = staff;
        }

        public override void Dismiss()
        {
            Employee trainee = Staff[0];
            for (int  i = 1;  i < Staff.Count;  i++)
            {
                if(trainee.Skill> Staff[i].Skill)
                {
                    trainee = Staff[i];
                }
            }
            Staff.Remove(trainee);
        }

        public override void Recuit(Employee person)
        {
            Staff.Add(person);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nDepartment Name : {DepartmentName}, Number of employee: {staff.Count}\nAll Staff:\n {GetAllStaff()}";
        }

        private object GetAllStaff()
        {
            string line = "";
            for (int i = 0; i < Staff.Count; i++)
            {
                line += $"{Staff[i].ToString()}\n";
            }
            return line;
        }
    }
}
