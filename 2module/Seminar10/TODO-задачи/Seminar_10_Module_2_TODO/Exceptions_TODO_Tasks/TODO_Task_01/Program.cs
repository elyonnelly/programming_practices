/* Напишите программу, подсчитывающую оценку студента ПИ по дисциплине программирование 2018 года на основе данных о 
 * количестве баллов за теоретический тест студента, максимального количество баллов за тест на потоке, накопленной оценки 
 * и оценки за выполнения экзаминационной контрольной работы. 
 * Для этого в библиотеке классов определите:
 * I. Класс SEStudent2018, хранящий информацию о студенте.
 * II. Класс ProgrammingResults2018 с необходимыми полями, в том числе с полем типа SEStudent2018 и cледующими свойствами:
 * 1) Свойство для перевода баллов за теоретический тест в оценку;
 * 2) Свойство для вычисления оценки за экзамен;
 * 3) Свойство для вычисления итоговой оценки за дисциплину.
 * III. Собственное исключение UnsatisfactoryException, возникающее в случае, если итоговая оценка за дисциплину меньше 4. 
 * В основной программе создайте экземпляр класса ProgrammingResults2018 и выведите оценку студента. 
 * Для каждого случая, когда оценка меньше 4 выведите отдельное сообщение по поводу оценки. */

using ClassLibrary;
using System;

/* TODO: переписать библиотеку классов для 2019 года.
 * Определить класс DisciplineResults2019, в котором определить поля accumulatedGrade, student и прототипы свойств GetExaminationGrade и GetFinalGrade.
 * Унаследовать от него класс ProgrammingResults2019, переопределить в нем ToString();
 * В основной программе создать массив или список из 10 студентов.
 * Фамилию и имя сгенерировать случайным образом длины от 3 до 10, первая буква – заглавная.
 * Оценка за тест случайное значение в промежутке [0, 40], остальные оценки из интервала [0, 10].
 * Вывести сведения о студентах и их итоговой оценке за дисциплину.
 * Внимание: программа должна выводить сведения и оценки ВСЕХ десяти студентов, даже если при попытке вычисления итоговой оценки было вызвано исключение.
 * Добавить повтор решения. */

namespace TODO_Task_01
{
    class Program
    {
        /// <summary>
        /// Метод возвращающий информацию о студенте в случае возникновения исключения UnsatisfactoryException
        /// </summary>
        /// <param name="e">Исключение</param>
        /// <param name="message">Сообщение, которое должна вывести программа</param>
        static void ReturnStudentInfoInCaseOfException(UnsatisfactoryException e, string message)
        {
            string studentInfo = e.Message.Remove(0, 1);
            Console.WriteLine($"{studentInfo}\n{message}");
        }
        static void Main(string[] args)
        {
            SEStudent2018 student;
            try
            {
                student = new SEStudent2018("Petr", "Ivanov", 187);
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
                return;
            }

            ProgrammingResults2018 programmingResults2018;
            try
            {
                programmingResults2018 = new ProgrammingResults2018(26, 10, 6, 3, student);
                Console.WriteLine($"Итоговая оценка: {programmingResults2018.GetFinalGrade}");
            }
            catch (UnsatisfactoryException e) when (e.Message[0] == '3')
            {
                ReturnStudentInfoInCaseOfException(e, "Итоговая оценка: 3, было очень близко :(");
            }
            catch (UnsatisfactoryException e) when (e.Message[0] == '2')
            {
                ReturnStudentInfoInCaseOfException(e, "Итоговая оценка: 2, good luck next time (на пересдаче).");
            }
            catch (UnsatisfactoryException e) when (e.Message[0] == '1')
            {
                ReturnStudentInfoInCaseOfException(e, "Итоговая оценка: 1, как-то совсем печально.");
            }
            catch (UnsatisfactoryException e) when (e.Message[0] == '0')
            {
                ReturnStudentInfoInCaseOfException(e, "Итоговая оценка: 0, говорят, в университет можно приходить.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
