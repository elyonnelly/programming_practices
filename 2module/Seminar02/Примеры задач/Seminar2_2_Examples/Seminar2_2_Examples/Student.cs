namespace Seminar2_2_Examples
{
    class Student
    {
        public string Surname { get; set; }
        private int course;

        //лямбда-выражения
        public int Course
        {
            get => course;
            set => course = 1 <= value && value <= 7 ? value : 1;
        }

        private string sex;

        //лямбда-выражения
        public string Sex
        {
            get => sex;
            set => sex = value == "Female" || value == "Male" ? value : "Male";
        }

        public string GetInfo()
        {
            return $"{Surname}, course {Course}, sex: {Sex}";
        }
    }
}