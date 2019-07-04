/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: Сгенерировать файл с людьми, считать его, сделать файл
 *         results.txt, записать туда результаты
 */

namespace TodoTasks
{
    public static class Human
    {
        private static string[] namesMale = { "Петя", "Ваня", "Саша", "Антон",
            "Федя", "Миша", "Макс", "Коля", "Вова", "Иннокентий" };

        private static string[] namesFemale = { "Маша", "Саша", "Катя", "Юля",
            "Наташа", "Лиля", "Алина", "Виталина", "Вика" };

        private static string[] surnamesMale = { "Петров", "Иванов", "Сидоров", "Басков",
            "Кузнецов", "Киркоров", "Бондарчук" };

        private static string[] surnamesFemale = { "Петрова", "Иванова", "Кузнецова",
            "Кюри", "Бузова", "Грейнджер", "Лавгуд" };

        public static string GetHumanMale()
        {
            string name = namesMale[Rand.Next(0, namesMale.Length)];
            string surname = surnamesMale[Rand.Next(0, surnamesMale.Length)];
            return name + ' ' + surname;
        }

        public static string GetHumanFemale()
        {
            string name = namesFemale[Rand.Next(0, namesFemale.Length)];
            string surname = namesFemale[Rand.Next(0, surnamesFemale.Length)];
            return name + ' ' + surname;
        }

        public static string GetHuman() => Rand.NextBool() ? GetHumanMale() : GetHumanFemale();
    }
}
