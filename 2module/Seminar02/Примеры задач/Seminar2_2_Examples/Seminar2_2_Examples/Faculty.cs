namespace Seminar2_2_Examples
{
    class Faculty
    {
        //константы должны быть инициализирован еще до компиляции, то есть
        //только значимые типы могут быть константами

        private const int CountOfCourses = 7;
        public string Name { get; set; }

        //Инкапсуляция в чистом виде -- мы позволяем узнавать состояние класса, но запрещаем
        //его модификацию вне класса.
        private int point;
        public int Point
        {
            get 
            {
                return point;
            }
            private set 
            {
                point = point + value < 0 ? point : point + value;
            }
        }
        public Student[] Students { get; set; }

        //мы позволяем изменять внутренние переменные вне класса не! напрямую
        public string ChangePoint(Professor professor ,int delta)
        {
            Point += delta;
            //напомним, что кавычки -- один из служебных символов, и их необходимо экранировать.
            return $"Professor {professor.Surname}: \"{delta} points to {Name}!\" ";
        }
        //статические методы относятся ко всему классу целиком и
        //обычно выполняют некоторый служебный функционал.
        //статические методы не могут внутри себя использовать нестатические члены класса
        public static int CountGirl(Faculty faculty)
        {
            var count = 0;
            foreach (var student in faculty.Students)
            {
                if (student.Sex == "Female")
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] CountStudentsOnCourse(Faculty faculty)
        {
            var countStudents = new int[CountOfCourses + 1];
            foreach (var student in faculty.Students)
            {
                countStudents[student.Course]++;
            }

            return countStudents;
        }
    }
}