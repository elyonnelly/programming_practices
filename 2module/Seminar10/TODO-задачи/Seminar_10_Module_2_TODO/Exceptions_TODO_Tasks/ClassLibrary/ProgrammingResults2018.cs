using System;

namespace ClassLibrary
{
    /// <summary>
    /// Класс результатов студента по дисциплине программирование
    /// </summary>
    public class ProgrammingResults2018
    {
        SEStudent2018 student;
        /// <summary>
        /// Количество баллов за теоретический тест
        /// </summary>
        int theoreticalTestScore;
        /// <summary>
        /// Максимальное количество баллов на потоке за теоретический тест
        /// </summary>
        int maxTestScore;
        /// <summary>
        /// Оценка за написание программы
        /// </summary>
        int programGrade;
        /// <summary>
        /// Накопленная оценка
        /// </summary>
        int accumulatedGrade;
        /// <summary>
        /// Результирующая оценка
        /// </summary>
        int finalGrade;

        /// <summary>
        /// Метод для определения принадлежности оценки необходимому интервалу.
        /// </summary>
        /// <param name="grade">Оценка</param>
        /// <param name="leftBorder">Левая граница интервала</param>
        /// <param name="rightBorder">Правая граница интервала</param>
        /// <returns></returns>
        bool checkGrade(int grade, int leftBorder, int rightBorder)
        {
            return (grade >= leftBorder & grade <= rightBorder);
        }

        /// Конструктор для создания экземпляра класса студента
        /// </summary>
        /// <param name="theoreticalTestGrade">Оценка за теоретический тест</param>
        /// <param name="programGrade">Оценка за написание программы</param>
        public ProgrammingResults2018(int maxTestScore, int theoreticalTestScore, int programGrade,
                                               int accumulatedGrade, SEStudent2018 student)
        {
            if (!checkGrade(maxTestScore, 0, 40) | !checkGrade(theoreticalTestScore, 0, 40) |
                !checkGrade(programGrade, 0, 10) | !checkGrade(accumulatedGrade, 0, 10))
                throw new ArgumentException("Одна или несколько оценок выходят за пределы возможного промежутка.");
            this.maxTestScore = maxTestScore;
            this.theoreticalTestScore = theoreticalTestScore;
            this.programGrade = programGrade;
            this.accumulatedGrade = accumulatedGrade;
            this.student = student;
            finalGrade = GetFinalGrade;
        }

        /// <summary>
        /// Свойства доступа к баллам и оценкам
        /// </summary>
        public int TheoreticalTestScore { get => theoreticalTestScore; }
        public int MaxTestScore { get => maxTestScore; }
        public int ProgramGrade { get => programGrade; }
        public int AccumulatedGrade { get => accumulatedGrade; }

        /// <summary>
        /// Свойство для перевода баллов за тест в оценку
        /// </summary>
        /// <returns></returns>
        public double GetTheoreticalTestGrade
        {
            get
            {
                if (theoreticalTestScore <= 10) return theoreticalTestScore / (double)4;
                if (maxTestScore == 11) return 4;
                if (maxTestScore >= 12 & maxTestScore <= 13)
                    return theoreticalTestScore * 5 / (double)maxTestScore;
                if (maxTestScore >= 14 & maxTestScore <= 15)
                    return theoreticalTestScore * 6 / (double)maxTestScore;
                if (maxTestScore >= 16 & maxTestScore <= 20)
                    return theoreticalTestScore * 7 / (double)maxTestScore;
                if (maxTestScore >= 21 & maxTestScore <= 25)
                    return theoreticalTestScore * 8 / (double)maxTestScore;
                if (maxTestScore >= 26 & maxTestScore <= 30)
                    return theoreticalTestScore * 9 / (double)maxTestScore;
                return theoreticalTestScore * 10 / (double)maxTestScore;
            }
        }

        /// <summary>
        /// Свойство для вычисления оценки за экзамен
        /// </summary>
        public double GetExaminationGrade
        {
            get => 0.8 * Math.Min(GetTheoreticalTestGrade, programGrade) + 0.2 * Math.Max(GetTheoreticalTestGrade, programGrade);
        }

        /// <summary>
        /// Свойство для вычисления итоговой оценки
        /// </summary>
        public int GetFinalGrade
        {
            get
            {
                int grade = (int)(0.2 * accumulatedGrade + 0.8 * GetExaminationGrade);
                if (grade < 4) throw new UnsatisfactoryException(grade.ToString() + this);
                return grade;
            }
        }

        // TODO: переопределить метод для вывода информации о результатах студента.
    }
}
